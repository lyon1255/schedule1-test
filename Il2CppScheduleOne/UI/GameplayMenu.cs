using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200063B RID: 1595
	public class GameplayMenu : Singleton<GameplayMenu>
	{
		// Token: 0x06008CE8 RID: 36072 RVA: 0x0024C028 File Offset: 0x0024A228
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenu()
		{
			Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr);
			GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ClosedVerticalOffset");
			GameplayMenu.NativeFieldInfoPtr_OpenTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OpenTime");
			GameplayMenu.NativeFieldInfoPtr_SlideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "SlideTime");
			GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<IsOpen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<CurrentScreen>k__BackingField");
			GameplayMenu.NativeFieldInfoPtr_OverlayCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayCamera");
			GameplayMenu.NativeFieldInfoPtr_OverlayLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "OverlayLight");
			GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "ContainerOffset_PhoneScreen");
			GameplayMenu.NativeFieldInfoPtr_openCloseRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "openCloseRoutine");
			GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "screenChangeRoutine");
			GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680797);
			GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680798);
			GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680799);
			GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680800);
			GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680801);
			GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680802);
			GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680803);
			GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680804);
			GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680805);
			GameplayMenu.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680806);
			GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680807);
			GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680808);
			GameplayMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, 100680809);
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x0024C238 File Offset: 0x0024A438
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0024C274 File Offset: 0x0024A474
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x0024C2B4 File Offset: 0x0024A4B4
		public unsafe bool CharacterScreenEnabled
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x06008CEC RID: 36076 RVA: 0x0024C2F0 File Offset: 0x0024A4F0
		// (set) Token: 0x06008CED RID: 36077 RVA: 0x0024C32C File Offset: 0x0024A52C
		public unsafe GameplayMenu.EGameplayScreen CurrentScreen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 178835, RefRangeEnd = 178836, XrefRangeStart = 178835, XrefRangeEnd = 178836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x0024C36C File Offset: 0x0024A56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257204, XrefRangeEnd = 257226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CEF RID: 36079 RVA: 0x0024C3A8 File Offset: 0x0024A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257226, XrefRangeEnd = 257236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF0 RID: 36080 RVA: 0x0024C3EC File Offset: 0x0024A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257236, XrefRangeEnd = 257285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenu.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF1 RID: 36081 RVA: 0x0024C428 File Offset: 0x0024A628
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257318, RefRangeEnd = 257321, XrefRangeStart = 257285, XrefRangeEnd = 257318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScreen(GameplayMenu.EGameplayScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x0024C468 File Offset: 0x0024A668
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 257448, RefRangeEnd = 257454, XrefRangeStart = 257321, XrefRangeEnd = 257448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x0024C4A8 File Offset: 0x0024A6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257454, XrefRangeEnd = 257457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x0024C4E4 File Offset: 0x0024A6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257470, RefRangeEnd = 257472, XrefRangeStart = 257457, XrefRangeEnd = 257470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x0024C518 File Offset: 0x0024A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257472, XrefRangeEnd = 257477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Boolean_PDM_0(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x00043982 File Offset: 0x00041B82
		public GameplayMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AFB RID: 11003
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x0024C564 File Offset: 0x0024A764
		// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x0004398B File Offset: 0x00041B8B
		public unsafe static float OpenVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17002AFC RID: 11004
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x0024C580 File Offset: 0x0024A780
		// (set) Token: 0x06008CFA RID: 36090 RVA: 0x00043999 File Offset: 0x00041B99
		public unsafe static float ClosedVerticalOffset
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_ClosedVerticalOffset, (void*)(&value));
			}
		}

		// Token: 0x17002AFD RID: 11005
		// (get) Token: 0x06008CFB RID: 36091 RVA: 0x0024C59C File Offset: 0x0024A79C
		// (set) Token: 0x06008CFC RID: 36092 RVA: 0x000439A7 File Offset: 0x00041BA7
		public unsafe static float OpenTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_OpenTime, (void*)(&value));
			}
		}

		// Token: 0x17002AFE RID: 11006
		// (get) Token: 0x06008CFD RID: 36093 RVA: 0x0024C5B8 File Offset: 0x0024A7B8
		// (set) Token: 0x06008CFE RID: 36094 RVA: 0x000439B5 File Offset: 0x00041BB5
		public unsafe static float SlideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameplayMenu.NativeFieldInfoPtr_SlideTime, (void*)(&value));
			}
		}

		// Token: 0x17002AFF RID: 11007
		// (get) Token: 0x06008CFF RID: 36095 RVA: 0x0024C5D4 File Offset: 0x0024A7D4
		// (set) Token: 0x06008D00 RID: 36096 RVA: 0x000439C3 File Offset: 0x00041BC3
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B00 RID: 11008
		// (get) Token: 0x06008D01 RID: 36097 RVA: 0x0024C5FC File Offset: 0x0024A7FC
		// (set) Token: 0x06008D02 RID: 36098 RVA: 0x000439DE File Offset: 0x00041BDE
		public unsafe GameplayMenu.EGameplayScreen _CurrentScreen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr__CurrentScreen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B01 RID: 11009
		// (get) Token: 0x06008D03 RID: 36099 RVA: 0x0024C624 File Offset: 0x0024A824
		// (set) Token: 0x06008D04 RID: 36100 RVA: 0x000439F9 File Offset: 0x00041BF9
		public unsafe Camera OverlayCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B02 RID: 11010
		// (get) Token: 0x06008D05 RID: 36101 RVA: 0x0024C654 File Offset: 0x0024A854
		// (set) Token: 0x06008D06 RID: 36102 RVA: 0x00043A18 File Offset: 0x00041C18
		public unsafe Light OverlayLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_OverlayLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x06008D07 RID: 36103 RVA: 0x0024C684 File Offset: 0x0024A884
		// (set) Token: 0x06008D08 RID: 36104 RVA: 0x00043A37 File Offset: 0x00041C37
		public unsafe float ContainerOffset_PhoneScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_ContainerOffset_PhoneScreen)) = value;
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x06008D09 RID: 36105 RVA: 0x0024C6AC File Offset: 0x0024A8AC
		// (set) Token: 0x06008D0A RID: 36106 RVA: 0x00043A52 File Offset: 0x00041C52
		public unsafe Coroutine openCloseRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_openCloseRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x06008D0B RID: 36107 RVA: 0x0024C6DC File Offset: 0x0024A8DC
		// (set) Token: 0x06008D0C RID: 36108 RVA: 0x00043A71 File Offset: 0x00041C71
		public unsafe Coroutine screenChangeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.NativeFieldInfoPtr_screenChangeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005F7A RID: 24442
		private static readonly IntPtr NativeFieldInfoPtr_OpenVerticalOffset;

		// Token: 0x04005F7B RID: 24443
		private static readonly IntPtr NativeFieldInfoPtr_ClosedVerticalOffset;

		// Token: 0x04005F7C RID: 24444
		private static readonly IntPtr NativeFieldInfoPtr_OpenTime;

		// Token: 0x04005F7D RID: 24445
		private static readonly IntPtr NativeFieldInfoPtr_SlideTime;

		// Token: 0x04005F7E RID: 24446
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005F7F RID: 24447
		private static readonly IntPtr NativeFieldInfoPtr__CurrentScreen_k__BackingField;

		// Token: 0x04005F80 RID: 24448
		private static readonly IntPtr NativeFieldInfoPtr_OverlayCamera;

		// Token: 0x04005F81 RID: 24449
		private static readonly IntPtr NativeFieldInfoPtr_OverlayLight;

		// Token: 0x04005F82 RID: 24450
		private static readonly IntPtr NativeFieldInfoPtr_ContainerOffset_PhoneScreen;

		// Token: 0x04005F83 RID: 24451
		private static readonly IntPtr NativeFieldInfoPtr_openCloseRoutine;

		// Token: 0x04005F84 RID: 24452
		private static readonly IntPtr NativeFieldInfoPtr_screenChangeRoutine;

		// Token: 0x04005F85 RID: 24453
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005F86 RID: 24454
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005F87 RID: 24455
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterScreenEnabled_Public_get_Boolean_0;

		// Token: 0x04005F88 RID: 24456
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentScreen_Public_get_EGameplayScreen_0;

		// Token: 0x04005F89 RID: 24457
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentScreen_Protected_set_Void_EGameplayScreen_0;

		// Token: 0x04005F8A RID: 24458
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005F8B RID: 24459
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04005F8C RID: 24460
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04005F8D RID: 24461
		private static readonly IntPtr NativeMethodInfoPtr_SetScreen_Public_Void_EGameplayScreen_0;

		// Token: 0x04005F8E RID: 24462
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04005F8F RID: 24463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F90 RID: 24464
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04005F91 RID: 24465
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Boolean_PDM_0;

		// Token: 0x02000B1F RID: 2847
		[OriginalName("Assembly-CSharp.dll", "", "EGameplayScreen")]
		public enum EGameplayScreen
		{
			// Token: 0x040090C1 RID: 37057
			Phone,
			// Token: 0x040090C2 RID: 37058
			Character
		}

		// Token: 0x02000B20 RID: 2848
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<<SetIsOpen>g__SetIsOpenRoutine|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D750 RID: 55120 RVA: 0x00333418 File Offset: 0x00331618
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique()
			{
				Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<<SetIsOpen>g__SetIsOpenRoutine|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "open");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<adjustedLerpTime>5__2");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<startVert>5__3");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<endVert>5__4");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, "<i>5__5");
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680810);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680811);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680812);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680813);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680814);
				GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr, 100680815);
			}

			// Token: 0x0600D751 RID: 55121 RVA: 0x0033355C File Offset: 0x0033175C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D752 RID: 55122 RVA: 0x003335A4 File Offset: 0x003317A4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D753 RID: 55123 RVA: 0x003335D8 File Offset: 0x003317D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257121, XrefRangeEnd = 257156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042C2 RID: 17090
			// (get) Token: 0x0600D754 RID: 55124 RVA: 0x00333614 File Offset: 0x00331814
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D755 RID: 55125 RVA: 0x00333654 File Offset: 0x00331854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257156, XrefRangeEnd = 257161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042C3 RID: 17091
			// (get) Token: 0x0600D756 RID: 55126 RVA: 0x00333688 File Offset: 0x00331888
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D757 RID: 55127 RVA: 0x00068D07 File Offset: 0x00066F07
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BA RID: 17082
			// (get) Token: 0x0600D758 RID: 55128 RVA: 0x003336C8 File Offset: 0x003318C8
			// (set) Token: 0x0600D759 RID: 55129 RVA: 0x00068D10 File Offset: 0x00066F10
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042BB RID: 17083
			// (get) Token: 0x0600D75A RID: 55130 RVA: 0x003336F0 File Offset: 0x003318F0
			// (set) Token: 0x0600D75B RID: 55131 RVA: 0x00068D2B File Offset: 0x00066F2B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BC RID: 17084
			// (get) Token: 0x0600D75C RID: 55132 RVA: 0x00333720 File Offset: 0x00331920
			// (set) Token: 0x0600D75D RID: 55133 RVA: 0x00068D4A File Offset: 0x00066F4A
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x170042BD RID: 17085
			// (get) Token: 0x0600D75E RID: 55134 RVA: 0x00333748 File Offset: 0x00331948
			// (set) Token: 0x0600D75F RID: 55135 RVA: 0x00068D65 File Offset: 0x00066F65
			public unsafe GameplayMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042BE RID: 17086
			// (get) Token: 0x0600D760 RID: 55136 RVA: 0x00333778 File Offset: 0x00331978
			// (set) Token: 0x0600D761 RID: 55137 RVA: 0x00068D84 File Offset: 0x00066F84
			public unsafe float _adjustedLerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__adjustedLerpTime_5__2)) = value;
				}
			}

			// Token: 0x170042BF RID: 17087
			// (get) Token: 0x0600D762 RID: 55138 RVA: 0x003337A0 File Offset: 0x003319A0
			// (set) Token: 0x0600D763 RID: 55139 RVA: 0x00068D9F File Offset: 0x00066F9F
			public unsafe float _startVert_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__startVert_5__3)) = value;
				}
			}

			// Token: 0x170042C0 RID: 17088
			// (get) Token: 0x0600D764 RID: 55140 RVA: 0x003337C8 File Offset: 0x003319C8
			// (set) Token: 0x0600D765 RID: 55141 RVA: 0x00068DBA File Offset: 0x00066FBA
			public unsafe float _endVert_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__endVert_5__4)) = value;
				}
			}

			// Token: 0x170042C1 RID: 17089
			// (get) Token: 0x0600D766 RID: 55142 RVA: 0x003337F0 File Offset: 0x003319F0
			// (set) Token: 0x0600D767 RID: 55143 RVA: 0x00068DD5 File Offset: 0x00066FD5
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoopGaSiSiObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040090C3 RID: 37059
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090C4 RID: 37060
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090C5 RID: 37061
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x040090C6 RID: 37062
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090C7 RID: 37063
			private static readonly IntPtr NativeFieldInfoPtr__adjustedLerpTime_5__2;

			// Token: 0x040090C8 RID: 37064
			private static readonly IntPtr NativeFieldInfoPtr__startVert_5__3;

			// Token: 0x040090C9 RID: 37065
			private static readonly IntPtr NativeFieldInfoPtr__endVert_5__4;

			// Token: 0x040090CA RID: 37066
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040090CB RID: 37067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090CC RID: 37068
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090CD RID: 37069
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090CE RID: 37070
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090CF RID: 37071
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090D0 RID: 37072
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B21 RID: 2849
		[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D768 RID: 55144 RVA: 0x00333818 File Offset: 0x00331A18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr);
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "screen");
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "<>4__this");
				GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "previousScreen");
				GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, 100680816);
				GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, 100680817);
			}

			// Token: 0x0600D769 RID: 55145 RVA: 0x003338A8 File Offset: 0x00331AA8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D76A RID: 55146 RVA: 0x003338E4 File Offset: 0x00331AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257199, XrefRangeEnd = 257204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D76B RID: 55147 RVA: 0x00068DF0 File Offset: 0x00066FF0
			public __c__DisplayClass23_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C4 RID: 17092
			// (get) Token: 0x0600D76C RID: 55148 RVA: 0x00333924 File Offset: 0x00331B24
			// (set) Token: 0x0600D76D RID: 55149 RVA: 0x00068DF9 File Offset: 0x00066FF9
			public unsafe GameplayMenu.EGameplayScreen screen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_screen)) = value;
				}
			}

			// Token: 0x170042C5 RID: 17093
			// (get) Token: 0x0600D76E RID: 55150 RVA: 0x0033394C File Offset: 0x00331B4C
			// (set) Token: 0x0600D76F RID: 55151 RVA: 0x00068E14 File Offset: 0x00067014
			public unsafe GameplayMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C6 RID: 17094
			// (get) Token: 0x0600D770 RID: 55152 RVA: 0x0033397C File Offset: 0x00331B7C
			// (set) Token: 0x0600D771 RID: 55153 RVA: 0x00068E33 File Offset: 0x00067033
			public unsafe GameplayMenu.EGameplayScreen previousScreen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.NativeFieldInfoPtr_previousScreen)) = value;
				}
			}

			// Token: 0x040090D1 RID: 37073
			private static readonly IntPtr NativeFieldInfoPtr_screen;

			// Token: 0x040090D2 RID: 37074
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090D3 RID: 37075
			private static readonly IntPtr NativeFieldInfoPtr_previousScreen;

			// Token: 0x040090D4 RID: 37076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090D5 RID: 37077
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C71 RID: 3185
			[ObfuscatedName("ScheduleOne.UI.GameplayMenu+<>c__DisplayClass23_0+<<SetScreen>g__ScreenChange|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E533 RID: 58675 RVA: 0x0035B428 File Offset: 0x00359628
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0>.NativeClassPtr, "<<SetScreen>g__ScreenChange|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<endXPos>5__2");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startXPos>5__3");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<t>5__4");
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680818);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680819);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680820);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680821);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680822);
					GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100680823);
				}

				// Token: 0x0600E534 RID: 58676 RVA: 0x0035B544 File Offset: 0x00359744
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E535 RID: 58677 RVA: 0x0035B58C File Offset: 0x0035978C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E536 RID: 58678 RVA: 0x0035B5C0 File Offset: 0x003597C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257161, XrefRangeEnd = 257194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004745 RID: 18245
				// (get) Token: 0x0600E537 RID: 58679 RVA: 0x0035B5FC File Offset: 0x003597FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E538 RID: 58680 RVA: 0x0035B63C File Offset: 0x0035983C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257194, XrefRangeEnd = 257199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004746 RID: 18246
				// (get) Token: 0x0600E539 RID: 58681 RVA: 0x0035B670 File Offset: 0x00359870
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E53A RID: 58682 RVA: 0x0006FC73 File Offset: 0x0006DE73
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700473F RID: 18239
				// (get) Token: 0x0600E53B RID: 58683 RVA: 0x0035B6B0 File Offset: 0x003598B0
				// (set) Token: 0x0600E53C RID: 58684 RVA: 0x0006FC7C File Offset: 0x0006DE7C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004740 RID: 18240
				// (get) Token: 0x0600E53D RID: 58685 RVA: 0x0035B6D8 File Offset: 0x003598D8
				// (set) Token: 0x0600E53E RID: 58686 RVA: 0x0006FC97 File Offset: 0x0006DE97
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004741 RID: 18241
				// (get) Token: 0x0600E53F RID: 58687 RVA: 0x0035B708 File Offset: 0x00359908
				// (set) Token: 0x0600E540 RID: 58688 RVA: 0x0006FCB6 File Offset: 0x0006DEB6
				public unsafe GameplayMenu.__c__DisplayClass23_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenu.__c__DisplayClass23_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004742 RID: 18242
				// (get) Token: 0x0600E541 RID: 58689 RVA: 0x0035B738 File Offset: 0x00359938
				// (set) Token: 0x0600E542 RID: 58690 RVA: 0x0006FCD5 File Offset: 0x0006DED5
				public unsafe float _endXPos_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__endXPos_5__2)) = value;
					}
				}

				// Token: 0x17004743 RID: 18243
				// (get) Token: 0x0600E543 RID: 58691 RVA: 0x0035B760 File Offset: 0x00359960
				// (set) Token: 0x0600E544 RID: 58692 RVA: 0x0006FCF0 File Offset: 0x0006DEF0
				public unsafe float _startXPos_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startXPos_5__3)) = value;
					}
				}

				// Token: 0x17004744 RID: 18244
				// (get) Token: 0x0600E545 RID: 58693 RVA: 0x0035B788 File Offset: 0x00359988
				// (set) Token: 0x0600E546 RID: 58694 RVA: 0x0006FD0B File Offset: 0x0006DF0B
				public unsafe float _t_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenu.__c__DisplayClass23_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__t_5__4)) = value;
					}
				}

				// Token: 0x04009945 RID: 39237
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009946 RID: 39238
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009947 RID: 39239
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009948 RID: 39240
				private static readonly IntPtr NativeFieldInfoPtr__endXPos_5__2;

				// Token: 0x04009949 RID: 39241
				private static readonly IntPtr NativeFieldInfoPtr__startXPos_5__3;

				// Token: 0x0400994A RID: 39242
				private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

				// Token: 0x0400994B RID: 39243
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400994C RID: 39244
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400994D RID: 39245
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400994E RID: 39246
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400994F RID: 39247
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009950 RID: 39248
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
