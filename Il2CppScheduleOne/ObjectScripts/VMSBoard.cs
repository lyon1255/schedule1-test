using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000729 RID: 1833
	public class VMSBoard : MonoBehaviour
	{
		// Token: 0x0600A589 RID: 42377 RVA: 0x00296F68 File Offset: 0x00295168
		// Note: this type is marked as 'beforefieldinit'.
		static VMSBoard()
		{
			Il2CppClassPointerStore<VMSBoard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VMSBoard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr);
			VMSBoard.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, "Label");
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683543);
			VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683544);
			VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr, 100683545);
		}

		// Token: 0x0600A58A RID: 42378 RVA: 0x00296FE8 File Offset: 0x002951E8
		[CallerCount(0)]
		public unsafe void SetText(string text, Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58B RID: 42379 RVA: 0x00297038 File Offset: 0x00295238
		[CallerCount(0)]
		public unsafe void SetText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58C RID: 42380 RVA: 0x0029707C File Offset: 0x0029527C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VMSBoard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VMSBoard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VMSBoard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A58D RID: 42381 RVA: 0x000518F8 File Offset: 0x0004FAF8
		public VMSBoard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A58E RID: 42382 RVA: 0x002970B8 File Offset: 0x002952B8
		// (set) Token: 0x0600A58F RID: 42383 RVA: 0x00051901 File Offset: 0x0004FB01
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VMSBoard.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006EFE RID: 28414
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006EFF RID: 28415
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_Color_0;

		// Token: 0x04006F00 RID: 28416
		private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;

		// Token: 0x04006F01 RID: 28417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
