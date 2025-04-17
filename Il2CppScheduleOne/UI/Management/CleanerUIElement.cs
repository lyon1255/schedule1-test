using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DA RID: 1754
	public class CleanerUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DAF RID: 40367 RVA: 0x0027DF94 File Offset: 0x0027C194
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerUIElement()
		{
			Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr);
			CleanerUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "StationsIcons");
			CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, "<AssignedCleaner>k__BackingField");
			CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682636);
			CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682637);
			CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682638);
			CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682639);
			CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr, 100682640);
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x06009DB0 RID: 40368 RVA: 0x0027E050 File Offset: 0x0027C250
		// (set) Token: 0x06009DB1 RID: 40369 RVA: 0x0027E090 File Offset: 0x0027C290
		public unsafe Cleaner AssignedCleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x0027E0D4 File Offset: 0x0027C2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279488, RefRangeEnd = 279489, XrefRangeStart = 279477, XrefRangeEnd = 279488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cleaner cleaner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleaner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB3 RID: 40371 RVA: 0x0027E118 File Offset: 0x0027C318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279489, XrefRangeEnd = 279502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x0027E154 File Offset: 0x0027C354
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x0004D5FB File Offset: 0x0004B7FB
		public CleanerUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x06009DB6 RID: 40374 RVA: 0x0027E190 File Offset: 0x0027C390
		// (set) Token: 0x06009DB7 RID: 40375 RVA: 0x0004D604 File Offset: 0x0004B804
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x06009DB8 RID: 40376 RVA: 0x0027E1C0 File Offset: 0x0027C3C0
		// (set) Token: 0x06009DB9 RID: 40377 RVA: 0x0004D623 File Offset: 0x0004B823
		public unsafe Cleaner _AssignedCleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerUIElement.NativeFieldInfoPtr__AssignedCleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069DF RID: 27103
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040069E0 RID: 27104
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCleaner_k__BackingField;

		// Token: 0x040069E1 RID: 27105
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCleaner_Public_get_Cleaner_0;

		// Token: 0x040069E2 RID: 27106
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x040069E3 RID: 27107
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cleaner_0;

		// Token: 0x040069E4 RID: 27108
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069E5 RID: 27109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
