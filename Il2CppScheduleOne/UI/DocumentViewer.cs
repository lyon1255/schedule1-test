using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000636 RID: 1590
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		// Token: 0x06008C91 RID: 35985 RVA: 0x0024AF48 File Offset: 0x00249148
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentViewer()
		{
			Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DocumentViewer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr);
			DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "<IsOpen>k__BackingField");
			DocumentViewer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Canvas");
			DocumentViewer.NativeFieldInfoPtr_Documents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "Documents");
			DocumentViewer.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, "onOpen");
			DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680752);
			DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680753);
			DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680754);
			DocumentViewer.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680755);
			DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680756);
			DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680757);
			DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr, 100680758);
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x06008C92 RID: 35986 RVA: 0x0024B054 File Offset: 0x00249254
		// (set) Token: 0x06008C93 RID: 35987 RVA: 0x0024B090 File Offset: 0x00249290
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x0024B0D0 File Offset: 0x002492D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256666, XrefRangeEnd = 256681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DocumentViewer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x0024B10C File Offset: 0x0024930C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256681, XrefRangeEnd = 256682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x0024B150 File Offset: 0x00249350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256728, RefRangeEnd = 256729, XrefRangeStart = 256682, XrefRangeEnd = 256728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string documentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(documentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x0024B194 File Offset: 0x00249394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256768, RefRangeEnd = 256769, XrefRangeStart = 256729, XrefRangeEnd = 256768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x0024B1C8 File Offset: 0x002493C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256769, XrefRangeEnd = 256772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentViewer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentViewer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentViewer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x000436CB File Offset: 0x000418CB
		public DocumentViewer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06008C9A RID: 35994 RVA: 0x0024B204 File Offset: 0x00249404
		// (set) Token: 0x06008C9B RID: 35995 RVA: 0x000436D4 File Offset: 0x000418D4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x0024B22C File Offset: 0x0024942C
		// (set) Token: 0x06008C9D RID: 35997 RVA: 0x000436EF File Offset: 0x000418EF
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06008C9E RID: 35998 RVA: 0x0024B25C File Offset: 0x0024945C
		// (set) Token: 0x06008C9F RID: 35999 RVA: 0x0004370E File Offset: 0x0004190E
		public unsafe Il2CppReferenceArray<RectTransform> Documents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_Documents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x06008CA0 RID: 36000 RVA: 0x0024B28C File Offset: 0x0024948C
		// (set) Token: 0x06008CA1 RID: 36001 RVA: 0x0004372D File Offset: 0x0004192D
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentViewer.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F43 RID: 24387
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005F44 RID: 24388
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005F45 RID: 24389
		private static readonly IntPtr NativeFieldInfoPtr_Documents;

		// Token: 0x04005F46 RID: 24390
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04005F47 RID: 24391
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005F48 RID: 24392
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005F49 RID: 24393
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005F4A RID: 24394
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005F4B RID: 24395
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x04005F4C RID: 24396
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005F4D RID: 24397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
