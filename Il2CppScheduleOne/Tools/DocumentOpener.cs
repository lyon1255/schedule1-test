using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000535 RID: 1333
	public class DocumentOpener : MonoBehaviour
	{
		// Token: 0x060076B2 RID: 30386 RVA: 0x00203D50 File Offset: 0x00201F50
		// Note: this type is marked as 'beforefieldinit'.
		static DocumentOpener()
		{
			Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "DocumentOpener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr);
			DocumentOpener.NativeFieldInfoPtr_DocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, "DocumentName");
			DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678246);
			DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr, 100678247);
		}

		// Token: 0x060076B3 RID: 30387 RVA: 0x00203DBC File Offset: 0x00201FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230942, XrefRangeEnd = 230948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076B4 RID: 30388 RVA: 0x00203DF0 File Offset: 0x00201FF0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DocumentOpener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DocumentOpener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DocumentOpener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076B5 RID: 30389 RVA: 0x000383F9 File Offset: 0x000365F9
		public DocumentOpener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x060076B6 RID: 30390 RVA: 0x00203E2C File Offset: 0x0020202C
		// (set) Token: 0x060076B7 RID: 30391 RVA: 0x00038402 File Offset: 0x00036602
		public unsafe string DocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DocumentOpener.NativeFieldInfoPtr_DocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400510E RID: 20750
		private static readonly IntPtr NativeFieldInfoPtr_DocumentName;

		// Token: 0x0400510F RID: 20751
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005110 RID: 20752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
