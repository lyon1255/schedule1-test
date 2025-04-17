using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000457 RID: 1111
	public static class LayerUtility : Il2CppSystem.Object
	{
		// Token: 0x06006098 RID: 24728 RVA: 0x0002DAB5 File Offset: 0x0002BCB5
		// Note: this type is marked as 'beforefieldinit'.
		static LayerUtility()
		{
			Il2CppClassPointerStore<LayerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LayerUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr);
			LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerUtility>.NativeClassPtr, 100675588);
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x001B99D4 File Offset: 0x001B7BD4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 199306, RefRangeEnd = 199332, XrefRangeStart = 199300, XrefRangeEnd = 199306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayerUtility.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x0002DAEE File Offset: 0x0002BCEE
		public LayerUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040041F0 RID: 16880
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;
	}
}
