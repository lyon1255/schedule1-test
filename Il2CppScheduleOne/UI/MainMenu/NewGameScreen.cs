using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EA RID: 1770
	public class NewGameScreen : MainMenuScreen
	{
		// Token: 0x06009E78 RID: 40568 RVA: 0x002807AC File Offset: 0x0027E9AC
		// Note: this type is marked as 'beforefieldinit'.
		static NewGameScreen()
		{
			Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "NewGameScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr);
			NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "ConfirmOverwriteScreen");
			NewGameScreen.NativeFieldInfoPtr_SetupScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, "SetupScreen");
			NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100682741);
			NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr, 100682742);
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x0028082C File Offset: 0x0027EA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280092, XrefRangeEnd = 280098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotSelected(int slotIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slotIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x0028086C File Offset: 0x0027EA6C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewGameScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewGameScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewGameScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x0004DBA2 File Offset: 0x0004BDA2
		public NewGameScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x002808A8 File Offset: 0x0027EAA8
		// (set) Token: 0x06009E7D RID: 40573 RVA: 0x0004DBAB File Offset: 0x0004BDAB
		public unsafe ConfirmOverwriteScreen ConfirmOverwriteScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOverwriteScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_ConfirmOverwriteScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x06009E7E RID: 40574 RVA: 0x002808D8 File Offset: 0x0027EAD8
		// (set) Token: 0x06009E7F RID: 40575 RVA: 0x0004DBCA File Offset: 0x0004BDCA
		public unsafe SetupScreen SetupScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewGameScreen.NativeFieldInfoPtr_SetupScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A5B RID: 27227
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmOverwriteScreen;

		// Token: 0x04006A5C RID: 27228
		private static readonly IntPtr NativeFieldInfoPtr_SetupScreen;

		// Token: 0x04006A5D RID: 27229
		private static readonly IntPtr NativeMethodInfoPtr_SlotSelected_Public_Void_Int32_0;

		// Token: 0x04006A5E RID: 27230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
