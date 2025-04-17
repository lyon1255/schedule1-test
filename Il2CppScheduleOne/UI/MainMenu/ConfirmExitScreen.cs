using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E2 RID: 1762
	public class ConfirmExitScreen : MainMenuScreen
	{
		// Token: 0x06009E1B RID: 40475 RVA: 0x0027F6A4 File Offset: 0x0027D8A4
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmExitScreen()
		{
			Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmExitScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr);
			ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, "TimeSinceSaveLabel");
			ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682695);
			ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682696);
			ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr, 100682697);
		}

		// Token: 0x06009E1C RID: 40476 RVA: 0x0027F724 File Offset: 0x0027D924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279801, XrefRangeEnd = 279814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x0027F758 File Offset: 0x0027D958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279814, XrefRangeEnd = 279820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr_ConfirmExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x0027F78C File Offset: 0x0027D98C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmExitScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmExitScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmExitScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x0004D8D8 File Offset: 0x0004BAD8
		public ConfirmExitScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x06009E20 RID: 40480 RVA: 0x0027F7C8 File Offset: 0x0027D9C8
		// (set) Token: 0x06009E21 RID: 40481 RVA: 0x0004D8E1 File Offset: 0x0004BAE1
		public unsafe TextMeshProUGUI TimeSinceSaveLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmExitScreen.NativeFieldInfoPtr_TimeSinceSaveLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A25 RID: 27173
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSaveLabel;

		// Token: 0x04006A26 RID: 27174
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A27 RID: 27175
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmExit_Public_Void_0;

		// Token: 0x04006A28 RID: 27176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
