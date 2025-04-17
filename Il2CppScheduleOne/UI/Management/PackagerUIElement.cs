using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DE RID: 1758
	public class PackagerUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DD7 RID: 40407 RVA: 0x0027E87C File Offset: 0x0027CA7C
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerUIElement()
		{
			Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr);
			PackagerUIElement.NativeFieldInfoPtr_StationRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "StationRects");
			PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, "<AssignedPackager>k__BackingField");
			PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682656);
			PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682657);
			PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682658);
			PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682659);
			PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr, 100682660);
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x06009DD8 RID: 40408 RVA: 0x0027E938 File Offset: 0x0027CB38
		// (set) Token: 0x06009DD9 RID: 40409 RVA: 0x0027E978 File Offset: 0x0027CB78
		public unsafe Packager AssignedPackager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x0027E9BC File Offset: 0x0027CBBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279568, RefRangeEnd = 279569, XrefRangeStart = 279557, XrefRangeEnd = 279568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Packager packager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(packager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x0027EA00 File Offset: 0x0027CC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279569, XrefRangeEnd = 279594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x0027EA3C File Offset: 0x0027CC3C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x0004D6D9 File Offset: 0x0004B8D9
		public PackagerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x0027EA78 File Offset: 0x0027CC78
		// (set) Token: 0x06009DDF RID: 40415 RVA: 0x0004D6E2 File Offset: 0x0004B8E2
		public unsafe Il2CppReferenceArray<RectTransform> StationRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr_StationRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x0027EAA8 File Offset: 0x0027CCA8
		// (set) Token: 0x06009DE1 RID: 40417 RVA: 0x0004D701 File Offset: 0x0004B901
		public unsafe Packager _AssignedPackager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerUIElement.NativeFieldInfoPtr__AssignedPackager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069F9 RID: 27129
		private static readonly IntPtr NativeFieldInfoPtr_StationRects;

		// Token: 0x040069FA RID: 27130
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPackager_k__BackingField;

		// Token: 0x040069FB RID: 27131
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPackager_Public_get_Packager_0;

		// Token: 0x040069FC RID: 27132
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPackager_Protected_set_Void_Packager_0;

		// Token: 0x040069FD RID: 27133
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Packager_0;

		// Token: 0x040069FE RID: 27134
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069FF RID: 27135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
