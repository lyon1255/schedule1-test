using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ExtendedComponents;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006EC RID: 1772
	public class SetupScreen : MainMenuScreen
	{
		// Token: 0x06009E8B RID: 40587 RVA: 0x00280BD8 File Offset: 0x0027EDD8
		// Note: this type is marked as 'beforefieldinit'.
		static SetupScreen()
		{
			Il2CppClassPointerStore<SetupScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "SetupScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr);
			SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "DEFAULT_SAVE_PATH");
			SetupScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "InputField");
			SetupScreen.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "StartButton");
			SetupScreen.NativeFieldInfoPtr_SkipIntroContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroContainer");
			SetupScreen.NativeFieldInfoPtr_SkipIntroToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "SkipIntroToggle");
			SetupScreen.NativeFieldInfoPtr_NotHostWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "NotHostWarning");
			SetupScreen.NativeFieldInfoPtr_slotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, "slotIndex");
			SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682750);
			SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682751);
			SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682752);
			SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682753);
			SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682754);
			SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682755);
			SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682756);
			SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682757);
			SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682758);
			SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr, 100682759);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x00280D5C File Offset: 0x0027EF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280217, XrefRangeEnd = 280229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupScreen.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x00280D98 File Offset: 0x0027EF98
		[CallerCount(0)]
		public unsafe void Initialize(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Initialize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x00280DD8 File Offset: 0x0027EFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280229, XrefRangeEnd = 280242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x00280E0C File Offset: 0x0027F00C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280324, RefRangeEnd = 280325, XrefRangeStart = 280242, XrefRangeEnd = 280324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_StartGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x00280E40 File Offset: 0x0027F040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280325, XrefRangeEnd = 280326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInputValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_IsInputValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009E91 RID: 40593 RVA: 0x00280E7C File Offset: 0x0027F07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280326, XrefRangeEnd = 280335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFolderContents(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E92 RID: 40594 RVA: 0x00280EC0 File Offset: 0x0027F0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280360, RefRangeEnd = 280361, XrefRangeStart = 280335, XrefRangeEnd = 280360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyDefaultSaveToFolder(string folderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E93 RID: 40595 RVA: 0x00280F04 File Offset: 0x0027F104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280361, XrefRangeEnd = 280376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E94 RID: 40596 RVA: 0x00280F4C File Offset: 0x0027F14C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E95 RID: 40597 RVA: 0x00280F88 File Offset: 0x0027F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280376, XrefRangeEnd = 280377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__7_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupScreen.NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E96 RID: 40598 RVA: 0x0004DC11 File Offset: 0x0004BE11
		public SetupScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06009E97 RID: 40599 RVA: 0x00280FCC File Offset: 0x0027F1CC
		// (set) Token: 0x06009E98 RID: 40600 RVA: 0x0004DC1A File Offset: 0x0004BE1A
		public unsafe static string DEFAULT_SAVE_PATH
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SetupScreen.NativeFieldInfoPtr_DEFAULT_SAVE_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06009E99 RID: 40601 RVA: 0x00280FEC File Offset: 0x0027F1EC
		// (set) Token: 0x06009E9A RID: 40602 RVA: 0x0004DC2C File Offset: 0x0004BE2C
		public unsafe GameInputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06009E9B RID: 40603 RVA: 0x0028101C File Offset: 0x0027F21C
		// (set) Token: 0x06009E9C RID: 40604 RVA: 0x0004DC4B File Offset: 0x0004BE4B
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06009E9D RID: 40605 RVA: 0x0028104C File Offset: 0x0027F24C
		// (set) Token: 0x06009E9E RID: 40606 RVA: 0x0004DC6A File Offset: 0x0004BE6A
		public unsafe RectTransform SkipIntroContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030CF RID: 12495
		// (get) Token: 0x06009E9F RID: 40607 RVA: 0x0028107C File Offset: 0x0027F27C
		// (set) Token: 0x06009EA0 RID: 40608 RVA: 0x0004DC89 File Offset: 0x0004BE89
		public unsafe Toggle SkipIntroToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_SkipIntroToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D0 RID: 12496
		// (get) Token: 0x06009EA1 RID: 40609 RVA: 0x002810AC File Offset: 0x0027F2AC
		// (set) Token: 0x06009EA2 RID: 40610 RVA: 0x0004DCA8 File Offset: 0x0004BEA8
		public unsafe RectTransform NotHostWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_NotHostWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D1 RID: 12497
		// (get) Token: 0x06009EA3 RID: 40611 RVA: 0x002810DC File Offset: 0x0027F2DC
		// (set) Token: 0x06009EA4 RID: 40612 RVA: 0x0004DCC7 File Offset: 0x0004BEC7
		public unsafe int slotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupScreen.NativeFieldInfoPtr_slotIndex)) = value;
			}
		}

		// Token: 0x04006A67 RID: 27239
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_SAVE_PATH;

		// Token: 0x04006A68 RID: 27240
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04006A69 RID: 27241
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04006A6A RID: 27242
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroContainer;

		// Token: 0x04006A6B RID: 27243
		private static readonly IntPtr NativeFieldInfoPtr_SkipIntroToggle;

		// Token: 0x04006A6C RID: 27244
		private static readonly IntPtr NativeFieldInfoPtr_NotHostWarning;

		// Token: 0x04006A6D RID: 27245
		private static readonly IntPtr NativeFieldInfoPtr_slotIndex;

		// Token: 0x04006A6E RID: 27246
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006A6F RID: 27247
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_0;

		// Token: 0x04006A70 RID: 27248
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A71 RID: 27249
		private static readonly IntPtr NativeMethodInfoPtr_StartGame_Public_Void_0;

		// Token: 0x04006A72 RID: 27250
		private static readonly IntPtr NativeMethodInfoPtr_IsInputValid_Private_Boolean_0;

		// Token: 0x04006A73 RID: 27251
		private static readonly IntPtr NativeMethodInfoPtr_ClearFolderContents_Private_Void_String_0;

		// Token: 0x04006A74 RID: 27252
		private static readonly IntPtr NativeMethodInfoPtr_CopyDefaultSaveToFolder_Private_Void_String_0;

		// Token: 0x04006A75 RID: 27253
		private static readonly IntPtr NativeMethodInfoPtr_CopyFilesRecursively_Private_Static_Void_String_String_0;

		// Token: 0x04006A76 RID: 27254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006A77 RID: 27255
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__7_0_Private_Void_String_0;
	}
}
