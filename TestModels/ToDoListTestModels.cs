using System.Collections.Generic;

namespace Carlton.Dashboard.Models.TestModels
{
    public static class ToDoListTestModels
    {
        public static ToDos DefaultToDoListModel()
        {
            var toDoList = new List<ToDo>
                   {
                        new ToDo(1, "Take Out Garbage", false),
                        new ToDo(2, "Go Shopping", false),
                        new ToDo(3, "Prepare Dinner", true)
                   };

            return new ToDos(toDoList);
        }

        public static ToDo ToDoListItemCheckedModel()
        {
            return new ToDo(1, "Take Out Garbage", true);
        }

        public static ToDo ToDoListItemUncheckedModel()
        {
            return new ToDo(1, "Take Out Garbage", false);
        }
    }
}
