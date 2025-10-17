using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventsTest
{
    public class EventsControllerTest
    {
        [Fact]
        public void Get_ReturnList()
        {
            //AAA
            //ARRANGE

            //ACT
            var controller = new EventsController();
            var result = controller.Get();

            //ASSERT
            Assert.IsType<List<Events>>(result);
        }
    }
}
