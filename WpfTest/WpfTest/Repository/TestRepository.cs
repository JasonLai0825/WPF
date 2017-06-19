using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTest.Context;
using WpfTest.Models;

namespace WpfTest.Repository
{
    class TestRepository
    {
        public Test_Post GetPostData()
        {
            return new TestContext().GetPostData();
        }
    }
}
