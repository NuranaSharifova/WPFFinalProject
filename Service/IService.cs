using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFFinalProject.Model;

namespace WPFFinalProject.Service
{
  
        public interface IService
        {
            List<Movie> Open(string filename);
            void Save(string filename, List<Movie> movies);
        }
   
}
