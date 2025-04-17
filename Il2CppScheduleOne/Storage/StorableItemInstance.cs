using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000573 RID: 1395
	[Serializable]
	public class StorableItemInstance : ItemInstance
	{
		// Token: 0x06007AB2 RID: 31410 RVA: 0x002105C4 File Offset: 0x0020E7C4
		// Note: this type is marked as 'beforefieldinit'.
		static StorableItemInstance()
		{
			Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorableItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr);
			StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678665);
			StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678666);
			StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678667);
			StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678668);
			StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr, 100678669);
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x06007AB3 RID: 31411 RVA: 0x00210658 File Offset: 0x0020E858
		public unsafe virtual StoredItem StoredItem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 234766, RefRangeEnd = 234768, XrefRangeStart = 234754, XrefRangeEnd = 234766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr3) : null;
			}
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x002106A4 File Offset: 0x0020E8A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 234769, RefRangeEnd = 234778, XrefRangeStart = 234768, XrefRangeEnd = 234769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x002106E0 File Offset: 0x0020E8E0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 234793, RefRangeEnd = 234811, XrefRangeStart = 234778, XrefRangeEnd = 234793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorableItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorableItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x0021073C File Offset: 0x0020E93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234811, XrefRangeEnd = 234830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00210794 File Offset: 0x0020E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234830, XrefRangeEnd = 234833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetMonetaryValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorableItemInstance.NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x0003A517 File Offset: 0x00038717
		public StorableItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005382 RID: 21378
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredItem_Public_Virtual_New_get_StoredItem_0;

		// Token: 0x04005383 RID: 21379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005384 RID: 21380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04005385 RID: 21381
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005386 RID: 21382
		private static readonly IntPtr NativeMethodInfoPtr_GetMonetaryValue_Public_Virtual_Single_0;
	}
}
