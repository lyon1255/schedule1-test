using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000639 RID: 1593
	public class FeedbackFormPopup : MonoBehaviour
	{
		// Token: 0x06008CCB RID: 36043 RVA: 0x0024BB70 File Offset: 0x00249D70
		// Note: this type is marked as 'beforefieldinit'.
		static FeedbackFormPopup()
		{
			Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "FeedbackFormPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr);
			FeedbackFormPopup.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "Label");
			FeedbackFormPopup.NativeFieldInfoPtr_AutoClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "AutoClose");
			FeedbackFormPopup.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, "closeTime");
			FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680790);
			FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680791);
			FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680792);
			FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr, 100680793);
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x0024BC2C File Offset: 0x00249E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257104, XrefRangeEnd = 257111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Open_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x0024BC70 File Offset: 0x00249E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194676, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x0024BCA4 File Offset: 0x00249EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257111, XrefRangeEnd = 257114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CCF RID: 36047 RVA: 0x0024BCD8 File Offset: 0x00249ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeedbackFormPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedbackFormPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeedbackFormPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CD0 RID: 36048 RVA: 0x00043871 File Offset: 0x00041A71
		public FeedbackFormPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x0024BD14 File Offset: 0x00249F14
		// (set) Token: 0x06008CD2 RID: 36050 RVA: 0x0004387A File Offset: 0x00041A7A
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x0024BD44 File Offset: 0x00249F44
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x00043899 File Offset: 0x00041A99
		public unsafe bool AutoClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_AutoClose)) = value;
			}
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x0024BD6C File Offset: 0x00249F6C
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x000438B4 File Offset: 0x00041AB4
		public unsafe float closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeedbackFormPopup.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04005F6A RID: 24426
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005F6B RID: 24427
		private static readonly IntPtr NativeFieldInfoPtr_AutoClose;

		// Token: 0x04005F6C RID: 24428
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04005F6D RID: 24429
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_0;

		// Token: 0x04005F6E RID: 24430
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005F6F RID: 24431
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F70 RID: 24432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
