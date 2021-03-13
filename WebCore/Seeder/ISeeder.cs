using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebCore.Seeder
{
    interface ISeeder
    {
        /**
         * Seed Models inside Context
         */
        void Seed(ModelBuilder builder);

    }
}
