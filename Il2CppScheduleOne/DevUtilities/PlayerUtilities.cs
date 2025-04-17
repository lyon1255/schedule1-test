using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000466 RID: 1126
	public static class PlayerUtilities : Object
	{
		// Token: 0x060061AB RID: 25003 RVA: 0x001BD2EC File Offset: 0x001BB4EC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerUtilities()
		{
			Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlayerUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr);
			PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100675705);
			PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerUtilities>.NativeClassPtr, 100675706);
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x001BD344 File Offset: 0x001BB544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201114, XrefRangeEnd = 201138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OpenMenu()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x001BD36C File Offset: 0x001BB56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201138, XrefRangeEnd = 201162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CloseMenu(bool reenableLookInstantly = false, bool reenableInventory = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableLookInstantly;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reenableInventory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerUtilities.NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x0002E287 File Offset: 0x0002C487
		public PlayerUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400429F RID: 17055
		private static readonly IntPtr NativeMethodInfoPtr_OpenMenu_Public_Static_Void_0;

		// Token: 0x040042A0 RID: 17056
		private static readonly IntPtr NativeMethodInfoPtr_CloseMenu_Public_Static_Void_Boolean_Boolean_0;
	}
}
