using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200057B RID: 1403
	public static class StorageVisualizationUtility : Object
	{
		// Token: 0x06007B80 RID: 31616 RVA: 0x0003A97B File Offset: 0x00038B7B
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizationUtility()
		{
			Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr);
			StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizationUtility>.NativeClassPtr, 100678783);
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x00213BFC File Offset: 0x00211DFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 236279, RefRangeEnd = 236281, XrefRangeStart = 236215, XrefRangeEnd = 236279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<StorableItemInstance, int> GetVisualRepresentation(Dictionary<StorableItemInstance, int> inputDictionary, int TotalFootprintSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDictionary);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref TotalFootprintSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizationUtility.NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x0003A9B4 File Offset: 0x00038BB4
		public StorageVisualizationUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400541B RID: 21531
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Static_Dictionary_2_StorableItemInstance_Int32_Dictionary_2_StorableItemInstance_Int32_Int32_0;
	}
}
