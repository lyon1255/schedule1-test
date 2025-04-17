using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000758 RID: 1880
	[Serializable]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		// Token: 0x0600B317 RID: 45847 RVA: 0x002CAC78 File Offset: 0x002C8E78
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberDefinition()
		{
			Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr);
			TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100685386);
			TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr, 100685387);
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x002CACD0 File Offset: 0x002C8ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308229, XrefRangeEnd = 308233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x002CAD28 File Offset: 0x002C8F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x00057C76 File Offset: 0x00055E76
		public TrashGrabberDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040078D5 RID: 30933
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078D6 RID: 30934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
