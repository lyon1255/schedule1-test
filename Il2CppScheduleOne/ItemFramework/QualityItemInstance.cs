using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005ED RID: 1517
	[Serializable]
	public class QualityItemInstance : StorableItemInstance
	{
		// Token: 0x0600847F RID: 33919 RVA: 0x00232E0C File Offset: 0x0023100C
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemInstance()
		{
			Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr);
			QualityItemInstance.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, "Quality");
			QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679884);
			QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679885);
			QualityItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679886);
			QualityItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679887);
			QualityItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679888);
			QualityItemInstance.NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr, 100679889);
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x00232EC8 File Offset: 0x002310C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 248781, RefRangeEnd = 248785, XrefRangeStart = 248780, XrefRangeEnd = 248781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x00232F04 File Offset: 0x00231104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248788, RefRangeEnd = 248790, XrefRangeStart = 248785, XrefRangeEnd = 248788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance(ItemDefinition definition, int quantity, EQuality quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x00232F6C File Offset: 0x0023116C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248793, RefRangeEnd = 248794, XrefRangeStart = 248790, XrefRangeEnd = 248793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStackWith(ItemInstance other, bool checkQuantities = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkQuantities;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x00232FD4 File Offset: 0x002311D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248794, XrefRangeEnd = 248801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x0023302C File Offset: 0x0023122C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248801, XrefRangeEnd = 248808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x00233078 File Offset: 0x00231278
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 247187, RefRangeEnd = 247192, XrefRangeStart = 247187, XrefRangeEnd = 247192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuality(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemInstance.NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x0003ECE0 File Offset: 0x0003CEE0
		public QualityItemInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x002330B8 File Offset: 0x002312B8
		// (set) Token: 0x06008488 RID: 33928 RVA: 0x0003ECE9 File Offset: 0x0003CEE9
		public unsafe EQuality Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInstance.NativeFieldInfoPtr_Quality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemInstance.NativeFieldInfoPtr_Quality)) = value;
			}
		}

		// Token: 0x04005A3E RID: 23102
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x04005A3F RID: 23103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A40 RID: 23104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EQuality_0;

		// Token: 0x04005A41 RID: 23105
		private static readonly IntPtr NativeMethodInfoPtr_CanStackWith_Public_Virtual_Boolean_ItemInstance_Boolean_0;

		// Token: 0x04005A42 RID: 23106
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A43 RID: 23107
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04005A44 RID: 23108
		private static readonly IntPtr NativeMethodInfoPtr_SetQuality_Public_Void_EQuality_0;
	}
}
