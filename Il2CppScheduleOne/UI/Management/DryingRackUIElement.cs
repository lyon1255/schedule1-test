using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DB RID: 1755
	public class DryingRackUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DBA RID: 40378 RVA: 0x0027E1F0 File Offset: 0x0027C3F0
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackUIElement()
		{
			Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr);
			DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "<AssignedRack>k__BackingField");
			DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, "TargetQualityIcon");
			DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682641);
			DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682642);
			DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682643);
			DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682644);
			DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr, 100682645);
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x06009DBB RID: 40379 RVA: 0x0027E2AC File Offset: 0x0027C4AC
		// (set) Token: 0x06009DBC RID: 40380 RVA: 0x0027E2EC File Offset: 0x0027C4EC
		public unsafe DryingRack AssignedRack
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x0027E330 File Offset: 0x0027C530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279512, RefRangeEnd = 279513, XrefRangeStart = 279502, XrefRangeEnd = 279512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x0027E374 File Offset: 0x0027C574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279513, XrefRangeEnd = 279523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x0027E3B0 File Offset: 0x0027C5B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x0004D642 File Offset: 0x0004B842
		public DryingRackUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x0027E3EC File Offset: 0x0027C5EC
		// (set) Token: 0x06009DC2 RID: 40386 RVA: 0x0004D64B File Offset: 0x0004B84B
		public unsafe DryingRack _AssignedRack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr__AssignedRack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x0027E41C File Offset: 0x0027C61C
		// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x0004D66A File Offset: 0x0004B86A
		public unsafe Image TargetQualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackUIElement.NativeFieldInfoPtr_TargetQualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069E6 RID: 27110
		private static readonly IntPtr NativeFieldInfoPtr__AssignedRack_k__BackingField;

		// Token: 0x040069E7 RID: 27111
		private static readonly IntPtr NativeFieldInfoPtr_TargetQualityIcon;

		// Token: 0x040069E8 RID: 27112
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedRack_Public_get_DryingRack_0;

		// Token: 0x040069E9 RID: 27113
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedRack_Protected_set_Void_DryingRack_0;

		// Token: 0x040069EA RID: 27114
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_DryingRack_0;

		// Token: 0x040069EB RID: 27115
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069EC RID: 27116
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
