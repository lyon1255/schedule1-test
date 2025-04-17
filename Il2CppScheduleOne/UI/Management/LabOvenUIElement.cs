using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DC RID: 1756
	public class LabOvenUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DC5 RID: 40389 RVA: 0x0027E44C File Offset: 0x0027C64C
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenUIElement()
		{
			Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr);
			LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, "<AssignedOven>k__BackingField");
			LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682646);
			LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682647);
			LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682648);
			LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682649);
			LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr, 100682650);
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x06009DC6 RID: 40390 RVA: 0x0027E4F4 File Offset: 0x0027C6F4
		// (set) Token: 0x06009DC7 RID: 40391 RVA: 0x0027E534 File Offset: 0x0027C734
		public unsafe LabOven AssignedOven
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x0027E578 File Offset: 0x0027C778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279533, RefRangeEnd = 279534, XrefRangeStart = 279523, XrefRangeEnd = 279533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x0027E5BC File Offset: 0x0027C7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279534, XrefRangeEnd = 279540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x0027E5F8 File Offset: 0x0027C7F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x0004D689 File Offset: 0x0004B889
		public LabOvenUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x06009DCC RID: 40396 RVA: 0x0027E634 File Offset: 0x0027C834
		// (set) Token: 0x06009DCD RID: 40397 RVA: 0x0004D692 File Offset: 0x0004B892
		public unsafe LabOven _AssignedOven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenUIElement.NativeFieldInfoPtr__AssignedOven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069ED RID: 27117
		private static readonly IntPtr NativeFieldInfoPtr__AssignedOven_k__BackingField;

		// Token: 0x040069EE RID: 27118
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedOven_Public_get_LabOven_0;

		// Token: 0x040069EF RID: 27119
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedOven_Protected_set_Void_LabOven_0;

		// Token: 0x040069F0 RID: 27120
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_LabOven_0;

		// Token: 0x040069F1 RID: 27121
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069F2 RID: 27122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
