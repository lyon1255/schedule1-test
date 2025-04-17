using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x020003FE RID: 1022
	public class IProceduralTileContainer : Il2CppObjectBase
	{
		// Token: 0x060055AC RID: 21932 RVA: 0x00029061 File Offset: 0x00027261
		// Note: this type is marked as 'beforefieldinit'.
		static IProceduralTileContainer()
		{
			Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "IProceduralTileContainer");
			IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IProceduralTileContainer>.NativeClassPtr, 100673988);
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x060055AD RID: 21933 RVA: 0x001908CC File Offset: 0x0018EACC
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IProceduralTileContainer.NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00029090 File Offset: 0x00027290
		public IProceduralTileContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A0F RID: 14863
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Abstract_Virtual_New_get_List_1_ProceduralTile_0;
	}
}
