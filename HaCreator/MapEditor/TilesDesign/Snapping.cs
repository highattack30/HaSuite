﻿/* Copyright (C) 2015 haha01haha01

* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System;
using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
using Microsoft.Xna.Framework;
using MapleLib.WzLib.WzStructure.Data;

namespace HaCreator.MapEditor.TilesDesign
{
    public static class TileSnap
    {
        public static MapleTable<string, MapTileDesign> tileCats;

        static TileSnap()
        {
            tileCats = new MapleTable<string, MapTileDesign>();
            tileCats["bsc"] = new bsc();
            tileCats["edU"] = new edU();
            tileCats["edD"] = new edD();
            tileCats["enH0"] = new enH0();
            tileCats["enH1"] = new enH1();
            tileCats["enV0"] = new enV0();
            tileCats["enV1"] = new enV1();
            tileCats["slLD"] = new slLD();
            tileCats["slLU"] = new slLU();
            tileCats["slRD"] = new slRD();
            tileCats["slRU"] = new slRU();
        }
    }
}

 


