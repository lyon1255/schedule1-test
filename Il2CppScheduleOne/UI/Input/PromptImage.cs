using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006F0 RID: 1776
	public class PromptImage : MonoBehaviour
	{
		// Token: 0x06009EEB RID: 40683 RVA: 0x00281DB0 File Offset: 0x0027FFB0
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImage()
		{
			Il2CppClassPointerStore<PromptImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImage>.NativeClassPtr);
			PromptImage.NativeFieldInfoPtr_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, "Width");
			PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImage>.NativeClassPtr, 100682784);
		}

		// Token: 0x06009EEC RID: 40684 RVA: 0x00281E08 File Offset: 0x00280008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280833, XrefRangeEnd = 280834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EED RID: 40685 RVA: 0x0004DF86 File Offset: 0x0004C186
		public PromptImage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030E9 RID: 12521
		// (get) Token: 0x06009EEE RID: 40686 RVA: 0x00281E44 File Offset: 0x00280044
		// (set) Token: 0x06009EEF RID: 40687 RVA: 0x0004DF8F File Offset: 0x0004C18F
		public unsafe float Width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImage.NativeFieldInfoPtr_Width)) = value;
			}
		}

		// Token: 0x04006AA2 RID: 27298
		private static readonly IntPtr NativeFieldInfoPtr_Width;

		// Token: 0x04006AA3 RID: 27299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
