using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _2dz_1zadatak
{
    class Program
    {
        

        public interface ITodoRepository
        {
            ///<summary>
            ///Getes TodoItem for a given id
            ///
            /// </summary>
            /// <returns>  TodoItem if found , null otherwise </returns>
            TodoItem Get(Guid todoId);

            ///<summary>
            ///Adds new TodoItem object in database
            ///If object with the same id already exists.
            ///method should throw DuplicateTodoItemException with the message "duplicate id : {id}".
            /// </summary>
            void Add(TodoItem todoId);

            ///<summary>
            ///Tries to remove a TodoItem with given id from the database
            ///</summary>
            ///<returns>True if sucess, false otherwise </returns>
            bool Remove(Guid todoId);

            ///<summary>
            ///Updates given Todo in database
            ///If Todo does not exist, method will add one.
            ///</summary>
            void Update(TodoItem todoItem);

            ///<summary>
            ///Tries to mark a Todoitem as completed in database
            /// </summary>
            /// <returns> True if success, false otherwise</returns>
            bool MarkAsCompleted(Guid todoId);

            ///<summary>
            ///Gets all TodoItem objects in database, sorted by date created(descending)
            /// </summary>
            List<TodoItem> GetAll();

            ///<summary>
            ///Gets all incomplete TodoItem objects in database
            /// </summary>
            List<TodoItem> GetActive();

            ///<summary>
            ///Gets all completed TodoItem objects in database
            /// </summary>
            List<TodoItem> GetCompleted();

            ///<summary>
            ///Gets all TodoItem objects in database that apply to the filter
            /// </summary>
            List<TodoItem> GetFiltered(Func<TodoItem, bool > filterFunction);
        }

        public class TodoRepository : ITodoRepository
        {
            public void Add(TodoItem todoId)
            {
                TodoItem tempItem = Get(todoId.Id);
                if(tempItem == todoId)
                {
                    throw new DuplicateTodoItemException();
                }
                TodoItem novi = new TodoItem();
                novi.Id = todoId.Id;
                bool postavi = MarkAsCompleted(todoId.Id);
            }

            public TodoItem Get(Guid todoId)
            {
                

                List<TodoItem> todoitems = GetTodoItemList();

                TodoItem todItem = todoitems.FirstOrDefault(p => p.Id == todoId);

                Console.WriteLine("Product "+todoId+ "exists: {0}", todItem != null);
                return todItem;
            }

            public List<TodoItem> GetActive()
            {
                List<TodoItem> todoitems = GetTodoItemList();

                return todoitems.Where(p => p.getIsCompleted == false).ToList();
            }

            public List<TodoItem> GetAll()
            {
                List<TodoItem> todoitems = GetTodoItemList();
                var sortedTodoItems =
                    from d in todoitems
                    orderby d.DateCreated descending
                    select d;
                return  sortedTodoItems.ToList();
            }

            public List<TodoItem> GetCompleted()
            {
                List<TodoItem> todoitems = GetTodoItemList();

                return todoitems.Where(p => p.getIsCompleted == true).ToList();
            }

            

            public List<TodoItem> GetFiltered(Func<TodoItem, bool > filterFunction )
            {
                List<TodoItem> todoitems = GetTodoItemList();
                return todoitems.Where(filterFunction).ToList();
            }

            public bool MarkAsCompleted(Guid todoId)
            {
                TodoItem MAC = Get(todoId);

                if (!MAC.getIsCompleted)
                {
                    bool IsCompleted = true;
                   DateTime DateCompleted = DateTime.Now;
                    return true;
                }                else
                {
                    return false;
                }
            }

            public bool Remove(Guid todoId)
            {
                List<TodoItem> todoitems = GetTodoItemList();

                todoitems =  todoitems.Where(p => p.Id != todoId).ToList();
                return true;
            }

            public void Update(TodoItem todoItem)
            {


                if (Get(todoItem.Id) == null)
                {
                    Add(todoItem);
                }
                else
                {
                    TodoItem stari = Get(todoItem.Id);
                    stari.Id = todoItem.Id;
                    stari.Text = todoItem.Text;
                    stari.getIsCompleted = todoItem.getIsCompleted;
                    stari.DateCompleted = todoItem.DateCompleted;
                    stari.DateCreated  = todoItem.DateCreated;

                }
            }
            public List<TodoItem> GetTodoItemList()
            {
                List<TodoItem> lista = new List<TodoItem>();
                return lista;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
