using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_Inventory_Manager
{

    // Class is still a work in progress
    class DatabaseTasks
    {
        legoinventorymanagerEntities brickEntities1, brickEntities2;
        public void showInventroy()
        {
            brickEntities1 = new legoinventorymanagerEntities();
            brickEntities2 = new legoinventorymanagerEntities();

            var query1 = (from b in brickEntities1.brick
                          join t in brickEntities1.type
                          on b.typeid equals t.typeid
                          select new
                          {
                              brickName = b.name,
                              brickType = t.name,
                              brickQuatity = b.quantity,
                              colorid = b.colorid
                          }).ToArray();


            var inventoryList = (from c in brickEntities2.color
                                 join arraybrick in query1
                                 on c.colorid equals arraybrick.colorid
                                 select new
                                 {
                                     brickName = arraybrick.brickName,
                                     brickType = arraybrick.brickType,
                                     brickColor = c.name,
                                     brickQuantity = arraybrick.brickQuatity
                                 }).ToList();
        }
    }
}
