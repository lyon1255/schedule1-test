using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppEasyButtons.Example
{
	// Token: 0x02000138 RID: 312
	public class CustomEditorButtonsExample : MonoBehaviour
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x000C2870 File Offset: 0x000C0A70
		// Note: this type is marked as 'beforefieldinit'.
		static CustomEditorButtonsExample()
		{
			Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "EasyButtons.Example", "CustomEditorButtonsExample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr);
			CustomEditorButtonsExample.NativeMethodInfoPtr_SayHello_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666080);
			CustomEditorButtonsExample.NativeMethodInfoPtr_SecondButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666081);
			CustomEditorButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr, 100666082);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000C28DC File Offset: 0x000C0ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97010, XrefRangeEnd = 97016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SayHello()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr_SayHello_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000C2910 File Offset: 0x000C0B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97016, XrefRangeEnd = 97022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SecondButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr_SecondButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000C2944 File Offset: 0x000C0B44
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomEditorButtonsExample() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomEditorButtonsExample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomEditorButtonsExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000EE7A File Offset: 0x0000D07A
		public CustomEditorButtonsExample(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr_SayHello_Private_Void_0;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr_SecondButton_Private_Void_0;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
