using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058A RID: 1418
	public class ItemModule : MonoBehaviour
	{
		// Token: 0x06007CD7 RID: 31959 RVA: 0x00217FB0 File Offset: 0x002161B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemModule()
		{
			Il2CppClassPointerStore<ItemModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "ItemModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemModule>.NativeClassPtr);
			ItemModule.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<Item>k__BackingField");
			ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<IsModuleActive>k__BackingField");
			ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678937);
			ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678938);
			ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678939);
			ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678940);
			ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678941);
			ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100678942);
		}

		// Token: 0x170025C4 RID: 9668
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x00218080 File Offset: 0x00216280
		// (set) Token: 0x06007CD9 RID: 31961 RVA: 0x002180C0 File Offset: 0x002162C0
		public unsafe StationItem Item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x00218104 File Offset: 0x00216304
		// (set) Token: 0x06007CDB RID: 31963 RVA: 0x00218140 File Offset: 0x00216340
		public unsafe bool IsModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x00218180 File Offset: 0x00216380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237467, XrefRangeEnd = 237468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x002181D0 File Offset: 0x002163D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x0003B469 File Offset: 0x00039669
		public ItemModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025C2 RID: 9666
		// (get) Token: 0x06007CDF RID: 31967 RVA: 0x0021820C File Offset: 0x0021640C
		// (set) Token: 0x06007CE0 RID: 31968 RVA: 0x0003B472 File Offset: 0x00039672
		public unsafe StationItem _Item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C3 RID: 9667
		// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x0021823C File Offset: 0x0021643C
		// (set) Token: 0x06007CE2 RID: 31970 RVA: 0x0003B491 File Offset: 0x00039691
		public unsafe bool _IsModuleActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField)) = value;
			}
		}

		// Token: 0x040054F8 RID: 21752
		private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

		// Token: 0x040054F9 RID: 21753
		private static readonly IntPtr NativeFieldInfoPtr__IsModuleActive_k__BackingField;

		// Token: 0x040054FA RID: 21754
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_StationItem_0;

		// Token: 0x040054FB RID: 21755
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0;

		// Token: 0x040054FC RID: 21756
		private static readonly IntPtr NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0;

		// Token: 0x040054FD RID: 21757
		private static readonly IntPtr NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0;

		// Token: 0x040054FE RID: 21758
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0;

		// Token: 0x040054FF RID: 21759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
