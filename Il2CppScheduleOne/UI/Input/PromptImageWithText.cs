using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006F1 RID: 1777
	public class PromptImageWithText : PromptImage
	{
		// Token: 0x06009EF0 RID: 40688 RVA: 0x00281E6C File Offset: 0x0028006C
		// Note: this type is marked as 'beforefieldinit'.
		static PromptImageWithText()
		{
			Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "PromptImageWithText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr);
			PromptImageWithText.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, "Label");
			PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr, 100682785);
		}

		// Token: 0x06009EF1 RID: 40689 RVA: 0x00281EC4 File Offset: 0x002800C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImageWithText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromptImageWithText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PromptImageWithText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x0004DFAA File Offset: 0x0004C1AA
		public PromptImageWithText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030EA RID: 12522
		// (get) Token: 0x06009EF3 RID: 40691 RVA: 0x00281F00 File Offset: 0x00280100
		// (set) Token: 0x06009EF4 RID: 40692 RVA: 0x0004DFB3 File Offset: 0x0004C1B3
		public unsafe TextMeshProUGUI Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PromptImageWithText.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006AA4 RID: 27300
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006AA5 RID: 27301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
