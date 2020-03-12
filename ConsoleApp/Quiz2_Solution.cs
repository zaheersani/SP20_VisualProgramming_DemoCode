using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<DeptTask> Tasks { get; set; }

        public DeptTask this[int index]
        {
            get
            {
                if(index < Tasks.Count)
                    return this.Tasks[index];
                return new DeptTask();
            }
        }

        public DeptTask this[string TaskCode]
        {
            get
            {
                //foreach (DeptTask item in Tasks)
                //{
                //    if (item.Code == TaskCode)
                //        return item;
                //}
                return Tasks.Find(x => x.Description.Contains(TaskCode) && x.Priority <= 1);
                return Tasks.Find(x => x.Code == TaskCode);
                return new DeptTask();
            }
        }

        public List<DeptTask> this[string Description, bool returnList]
        {
            get
            {
                return Tasks.FindAll(x => x.Description.Contains(Description));
            }
        }
    }
    struct DeptTask
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DeptTask(string code, int priority, string desc)
        {
            this.Code = code;
            this.Priority = priority;
            this.Description = desc;
        }
    }
}
