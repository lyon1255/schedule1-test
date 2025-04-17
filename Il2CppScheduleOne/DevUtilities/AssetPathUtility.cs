﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044C RID: 1100
	public static class AssetPathUtility : Il2CppSystem.Object
	{
		// Token: 0x06005FA9 RID: 24489 RVA: 0x0002D1EE File Offset: 0x0002B3EE
		// Note: this type is marked as 'beforefieldinit'.
		static AssetPathUtility()
		{
			Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AssetPathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr);
			AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetPathUtility>.NativeClassPtr, 100675503);
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x001B6EC4 File Offset: 0x001B50C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198539, XrefRangeEnd = 198541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourcesPath(UnityEngine.Object selectedObject)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectedObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetPathUtility.NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x0002D227 File Offset: 0x0002B427
		public AssetPathUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400415F RID: 16735
		private static readonly IntPtr NativeMethodInfoPtr_GetResourcesPath_Public_Static_String_Object_0;
	}
}
