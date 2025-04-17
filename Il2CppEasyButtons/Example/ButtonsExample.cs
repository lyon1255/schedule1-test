using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000137 RID: 311
	public class ButtonsExample : MonoBehaviour
	{
		// Token: 0x06001A32 RID: 6706 RVA: 0x000C2548 File Offset: 0x000C0748
		// Note: this type is marked as 'beforefieldinit'.
		static ButtonsExample()
		{
			Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "ButtonsExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr);
			ButtonsExample.NativeMethodInfoPtr_SayMyName_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666070);
			ButtonsExample.NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666071);
			ButtonsExample.NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666072);
			ButtonsExample.NativeMethodInfoPtr_TestButtonName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666073);
			ButtonsExample.NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666074);
			ButtonsExample.NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666075);
			ButtonsExample.NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666076);
			ButtonsExample.NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666077);
			ButtonsExample.NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666078);
			ButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr, 100666079);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x000C2640 File Offset: 0x000C0840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96955, XrefRangeEnd = 96960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayMyName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayMyName_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000C2674 File Offset: 0x000C0874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96960, XrefRangeEnd = 96966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloEditor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000C26A8 File Offset: 0x000C08A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96966, XrefRangeEnd = 96972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHelloInRuntime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000C26DC File Offset: 0x000C08DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96972, XrefRangeEnd = 96978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000C2710 File Offset: 0x000C0910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96978, XrefRangeEnd = 96984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonNameEditorOnly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000C2744 File Offset: 0x000C0944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96984, XrefRangeEnd = 96990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TestStaticMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000C276C File Offset: 0x000C096C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96990, XrefRangeEnd = 96996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonSpaceBoth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x000C27A0 File Offset: 0x000C09A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96996, XrefRangeEnd = 97006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestButtonWithParams(string message, int number)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000C27F0 File Offset: 0x000C09F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97006, XrefRangeEnd = 97010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestExpandedButton(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000C2834 File Offset: 0x000C0A34
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ButtonsExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ButtonsExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0000EE71 File Offset: 0x0000D071
		public ButtonsExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr_SayMyName_Public_Void_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloEditor_Protected_Void_0;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeMethodInfoPtr_SayHelloInRuntime_Private_Void_0;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonName_Private_Void_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonNameEditorOnly_Private_Void_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_TestStaticMethod_Private_Static_Void_0;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonSpaceBoth_Private_Void_0;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeMethodInfoPtr_TestButtonWithParams_Private_Void_String_Int32_0;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeMethodInfoPtr_TestExpandedButton_Private_Void_String_0;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
