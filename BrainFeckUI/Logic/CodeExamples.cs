﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace func.brainfuck
{
    public static class CodeExamples
    {
        public static List<string> CodeExamplesList = new List<string>
        {
           @"++++[++++>---<]>-.---[----->+<]>-.+++[->+++<]>++.++++++++
            .+++++.--------.-[--->+<]>--.+[->+++<]>+.++++++++.-[++>---<]
            >+.-[--->++<]>-.++++++++++.+[---->+<]>+++.[->+++<]>+.+++++++++++++.-
            [->+++++<]>-.+[->+++<]>++.[--->+<]>----.----.+++++.+++[->+++<]>
            .+++++++++++++.---------.------.[--->+<]>-.[-->+++++++<]>.++.---
            .--------.+++++++++++.+++[->+++<]>++.++++++++++++..----.+++++.--
            -----.-[--->+<]>--.++[--->++<]>.-----------.+++++++++++++.-------.
            --[--->+<]>--.[->+++<]>++.++++++.--.--[--->+<]>-.+[->+++<]>.-[--->+<]
            >----.-------------.----.--[--->+<]>-.+++[->+++<]>.-.-[--->+<]>-.-[--
            ->++<]>-.+++++.-[->+++++<]>-.[-->+++<]>+.++++++++..------.[--->++<]>--.
            [->+++<]>++.[--->+<]>+++.-[---->+<]>++.>-[--->+<]>.+[--->+<]>.++++[->+++<]>
            .-.+++++++++++++.-[->+++++<]>-.++++++[->++<]>+.>----.[------->+++<]>..----
            ---.+++++++++++++.",

            @"-[------->+<]>.-[->++++<]>.--[->++++<]>-.-[->+++<]>-.--[--->+<]>--.+
            [---->+<]>+++.+[----->+<]>.------------.+++.+.--[--->+<]>-.++[->+++<]
            >.+++++++++.+++.[-->+++++<]>+++.++[--->++<]>.+++.+++++++.[------>+<]
            >.+++++.-------.-[--->+<]>--.--[->++++<]>+.----------.++++++.-[++>---<]
            >--.------------.[->+++<]>++.-.+.[--->+<]>+++.-[-->+++++<]>.------------.--
            [->++++<]>+.----------.++++++.-[---->+<]>+++.--[->++++<]>-.[->+++<]
            >.+++++++++++++.-------------.--[--->+<]>-.+[----->+<]>.------------.+++.+.--
            [--->+<]>-.++[->+++<]>.+++++++++.+++.[-->+++++<]>+++.++[--->++<]>.+++.+++++++.
            [------>+<]>.+++++.[++>---<]>++.-------.+[----->+<]>.--------.",

            @"-[--->+<]>---.----[-->+++<]>.--..----------.--------.+++++++++++++.-[->+++++<]
            >-.-[--->++<]>--.-------.++.++++++++.------.+++++++++++++.+.+[---->+<]>+++.[->+++<]
            >+.--[--->+<]>---.-------------.--[--->+<]>-.--[->++++<]>-.-[->+++<]>-.--[--->+<]
            >-.++[->+++<]>+.+++++.+.+++++.-------.-[--->+<]>-.",

            @"+[--->++<]>+.++[->++++<]>+.--[--->+<]>-.+[----->+<]>+.---------..-.-[--->+<]
            >-.+[----->+<]>.++.+++.-------------.--[--->+<]>-.++[->+++<]>+.++++++++.---.--------.-[--->+<]>.",

            @"-[------->+<]>.[----->+<]>-.[---->+<]>+++.-[--->++<]>-.++++++++++.+[---->+<]>+++.-[--->++<]
            >-.+++++.+++++.++[->+++<]>++.+++++++++++++.---------.--[--->+<]>-.-[--->++<]>--.+++++++.++++++++.+
            [---->+<]>++.++[--->++<]>.+++.-.-------.-[--->+<]>--.-[--->++<]>-.+++++++++++.[---->+<]>+++.---
            [->++++<]>.+[->+++<]>++.++++++++++.------.[--->+<]>----.+[---->+<]>+++.---[->++++<]>.-----.[--->+<]
            >-----.--[->++++<]>-.-----.---------.+++++++++++.+++[->+++<]>.--[--->+<]>-.[->+++<]>+.-[->+++<]>.---
            [->++++<]>-.----------.++++.+++.----.-------.--[--->+<]>-.[-->+++++++<]>.++.---.--------.+++++++++++.+++
            [->+++<]>++.++++++++++++.[->+++++<]>-.-[--->++<]>-.+++++.-[->+++++<]>-.---[->++++<]>.------------.+.++++++++++.+
            [---->+<]>+++.++[--->++<]>.-----------.+++++++++++++.-------.--[--->+<]>--.[->+++<]>++.++++++.--.--[--->+<]
            >.-.++++++[->++<]>.+[--->+<]>..----.-[++>---<]>+.[->+++<]>+.--[--->+<]>-.[---->+<]>+++.[->+++<]>+.+++++++++++..
            [++>---<]>--.---[->++++<]>.------------.---.[--->+<]>----.++++[->+++<]>.--[--->+<]>-.---[->++++<]>-.++++++.
            [->+++<]>++.-----------.+++++++++++++.---.+++++++.+[-->+++++<]>-.",

            @"+[----->+++<]>+.++++++++++++..----.+++.+[-->+<]>.-----------..[--->+<]>.+++++++++.[----->++<]>++.[--->++<]>+++.+
            [->+++<]>+.++.--.+++++++.-----------.-.+++++.--------.-[-->+<]>--.---[----->+<]>.+++.-----------.--[->+++<]>.++
            [--->++<]>+.+[->+++<]>+.++.--.----[->+++<]>.[----->++<]>.--[-->+++<]>-.--.++++++++.--[--->+<]>.+[->++<]>+.+[--->+<]
            >.---------------.---[->++++<]>.-.+.+++++.---------.-----------.--[--->+<]>---.+++[->+++<]>.++++.-[--->+<]
            >-.---------.++++++++.+.---.-------------.",


            @"-[------->+<]>--.[--->+<]>++.-----------.[->+++<]>.------------.++++[->++<]>+.+[-->+<]
            >++.-[--->+<]>++.-[--->+<]>-.++[--->++<]>.+++.+++++++.+[->+++<]>.--[--->+<]>-.---[->++++<]
            >.-----.[--->+<]>-----.+[->+++<]>++.----.--[--->+<]>-.[---->+<]>+++.---[->++++<]>-.----.--.--------.
            [--->+<]>---.------------.+.+++++.-------.-[--->+<]>--.---[----->++<]>.---------.--.+.++++++++++++.
            [---->+<]>+++.+[----->+<]>+.+.++++++++.+[---->+<]>+++.",

            @"++[---------->+<]>.-[++++>---<]>.-[---->+<]>++.+[----->+<]>+.-------------.++++++++++++.--------.--
            [--->+<]>-.-[--->++<]>-.++++++++++.+[---->+<]>+++.+[->++<]>.-[--->+<]>++++.-.----------.
            [->+++<]>++.++[--->++<]>.+++++[->++<]>.--[--->++++<]>+.++++++++++++.--------.[--->+<]>----.+[---->+<]
            >+++.+[->++<]>.-[--->+<]>++++.-.----------.[->+++<]>++.",

            @"--------[-->+++<]>.------------.---.[--->+<]>----.++++[->+++<]>.--[--->+<]>-.[->+++<]>+.--[--->+<]
            >---.-------------.--[--->+<]>-.+[----->+<]>+.+.+++++.[---->+<]>+++.---[->++++<]>.------------.---.--
            [--->+<]>-.+[->+++<]>+.++++++++++++++.---.------.-----.--[--->+<]>---.+[---->+<]>+++.--[->++++<]
            >+.----------.++++++.[--->+<]>.-[->+++<]>.-------------.--[--->+<]>-.++[--->++<]>.+++..----.--.+++++.
            -------.-[--->+<]>--.++[->+++<]>.+++++++++.+++."

        };
    }
}