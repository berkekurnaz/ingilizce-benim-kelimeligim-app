using IngilizceKelimeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceKelimeApp.Database
{
    public class WordManager : BaseRepository<Word>
    {
        string repoName;

        public WordManager(string repoName) : base(repoName)
        {
            this.repoName = repoName;
        }
    }
}
