using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class ToDoTests
    {

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewToDo_CommentNullOrEmpty(string? comment)
        {
            Exception? result = Assert.Throws<Exception>(() => new ToDo(1, comment));
            Assert.NotNull(result);
        }
    }
}
