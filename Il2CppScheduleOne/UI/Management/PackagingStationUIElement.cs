using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DF RID: 1759
	public class PackagingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DE2 RID: 40418 RVA: 0x0027EAD8 File Offset: 0x0027CCD8
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationUIElement()
		{
			Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr);
			PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682661);
			PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682662);
			PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682663);
			PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682664);
			PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr, 100682665);
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x0027EB80 File Offset: 0x0027CD80
		// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x0027EBC0 File Offset: 0x0027CDC0
		public unsafe PackagingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x0027EC04 File Offset: 0x0027CE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279604, RefRangeEnd = 279605, XrefRangeStart = 279594, XrefRangeEnd = 279604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(PackagingStation pack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x0027EC48 File Offset: 0x0027CE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279605, XrefRangeEnd = 279611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x0027EC84 File Offset: 0x0027CE84
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0004D720 File Offset: 0x0004B920
		public PackagingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x06009DE9 RID: 40425 RVA: 0x0027ECC0 File Offset: 0x0027CEC0
		// (set) Token: 0x06009DEA RID: 40426 RVA: 0x0004D729 File Offset: 0x0004B929
		public unsafe PackagingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A00 RID: 27136
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x04006A01 RID: 27137
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_PackagingStation_0;

		// Token: 0x04006A02 RID: 27138
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_PackagingStation_0;

		// Token: 0x04006A03 RID: 27139
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PackagingStation_0;

		// Token: 0x04006A04 RID: 27140
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x04006A05 RID: 27141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
