using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E4 RID: 1764
	public class ContinueScreen : MainMenuScreen
	{
		// Token: 0x06009E2B RID: 40491 RVA: 0x0027F994 File Offset: 0x0027DB94
		// Note: this type is marked as 'beforefieldinit'.
		static ContinueScreen()
		{
			Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ContinueScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr);
			ContinueScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, "NotHostWarning");
			ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100682701);
			ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100682702);
			ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr, 100682703);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x0027FA14 File Offset: 0x0027DC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279821, XrefRangeEnd = 279828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x0027FA48 File Offset: 0x0027DC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279828, XrefRangeEnd = 279850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadGame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x0027FA88 File Offset: 0x0027DC88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContinueScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinueScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContinueScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x0004D943 File Offset: 0x0004BB43
		public ContinueScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B3 RID: 12467
		// (get) Token: 0x06009E30 RID: 40496 RVA: 0x0027FAC4 File Offset: 0x0027DCC4
		// (set) Token: 0x06009E31 RID: 40497 RVA: 0x0004D94C File Offset: 0x0004BB4C
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContinueScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A2E RID: 27182
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x04006A2F RID: 27183
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A30 RID: 27184
		private static readonly IntPtr NativeMethodInfoPtr_LoadGame_Public_Void_Int32_0;

		// Token: 0x04006A31 RID: 27185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
