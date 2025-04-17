using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E3 RID: 1763
	public class ConfirmOverwriteScreen : MainMenuScreen
	{
		// Token: 0x06009E22 RID: 40482 RVA: 0x0027F7F8 File Offset: 0x0027D9F8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOverwriteScreen()
		{
			Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "ConfirmOverwriteScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr);
			ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "SetupScreen");
			ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, "slotIndex");
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682698);
			ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682699);
			ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr, 100682700);
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x0027F88C File Offset: 0x0027DA8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48691, RefRangeEnd = 48694, XrefRangeStart = 48691, XrefRangeEnd = 48694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x0027F8CC File Offset: 0x0027DACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279820, XrefRangeEnd = 279821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E25 RID: 40485 RVA: 0x0027F900 File Offset: 0x0027DB00
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOverwriteScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOverwriteScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOverwriteScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E26 RID: 40486 RVA: 0x0004D900 File Offset: 0x0004BB00
		public ConfirmOverwriteScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x06009E27 RID: 40487 RVA: 0x0027F93C File Offset: 0x0027DB3C
		// (set) Token: 0x06009E28 RID: 40488 RVA: 0x0004D909 File Offset: 0x0004BB09
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x06009E29 RID: 40489 RVA: 0x0027F96C File Offset: 0x0027DB6C
		// (set) Token: 0x06009E2A RID: 40490 RVA: 0x0004D928 File Offset: 0x0004BB28
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOverwriteScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006A29 RID: 27177
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006A2A RID: 27178
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006A2B RID: 27179
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006A2C RID: 27180
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Public_Void_0;

		// Token: 0x04006A2D RID: 27181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
