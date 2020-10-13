﻿using Perpetuum.Containers;
using Perpetuum.ExportedTypes;
using Perpetuum.Modules;
using Perpetuum.Modules.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Perpetuum.DataDumper.DataDumper;

namespace Perpetuum.DataDumper.Views {
    public class ModuleDrillerDataView : ActiveModuleDataView {
        public double module_mining_modifier { get; set; }

        public ModuleDrillerDataView(DrillerModule item, DataDumper dumper) {
            dumper.InitActiveModuleView(this, item);

            module_mining_modifier = item.GetBasePropertyModifier(AggregateField.mining_amount_modifier).Value;
        }
    }
}
