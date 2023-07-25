﻿// Overstrike -- an open-source mod manager for PC ports of Insomniac Games' games.
// This program is free software, and can be redistributed and/or modified by you. It is provided 'as-is', without any warranty.
// For more details, terms and conditions, see GNU General Public License.
// A copy of the that license should come with this program (LICENSE.txt). If not, see <http://www.gnu.org/licenses/>.

using System.IO;
using DAT1.Sections.Generic;

namespace DAT1.Sections.Config
{
    public class ConfigReferencesSection: ReferencesSection
    {
        public const uint TAG = 0x58B8558A; // Config Asset Refs

        public ConfigReferencesSection(BinaryReader r, uint size): base(r, size) {}
    }
}
