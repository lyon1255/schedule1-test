using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI.MainMenu;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064E RID: 1614
	public class PauseMenu : Singleton<PauseMenu>
	{
		// Token: 0x06008F3B RID: 36667 RVA: 0x00252B90 File Offset: 0x00250D90
		// Note: this type is marked as 'beforefieldinit'.
		static PauseMenu()
		{
			Il2CppClassPointerStore<PauseMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PauseMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr);
			PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "<IsPaused>k__BackingField");
			PauseMenu.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Canvas");
			PauseMenu.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Container");
			PauseMenu.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "Screen");
			PauseMenu.NativeFieldInfoPtr_FeedbackForm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "FeedbackForm");
			PauseMenu.NativeFieldInfoPtr_noActiveUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "noActiveUIElements");
			PauseMenu.NativeFieldInfoPtr_justPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justPaused");
			PauseMenu.NativeFieldInfoPtr_justResumed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "justResumed");
			PauseMenu.NativeFieldInfoPtr_couldLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "couldLook");
			PauseMenu.NativeFieldInfoPtr_lockedMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "lockedMouse");
			PauseMenu.NativeFieldInfoPtr_crosshairVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "crosshairVisible");
			PauseMenu.NativeFieldInfoPtr_hudVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "hudVisible");
			PauseMenu.NativeFieldInfoPtr_onPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onPause");
			PauseMenu.NativeFieldInfoPtr_onResume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, "onResume");
			PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681065);
			PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681066);
			PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681067);
			PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681068);
			PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681069);
			PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681070);
			PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681071);
			PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681072);
			PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681073);
			PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681074);
			PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr, 100681075);
		}

		// Token: 0x17002BDC RID: 11228
		// (get) Token: 0x06008F3C RID: 36668 RVA: 0x00252DB4 File Offset: 0x00250FB4
		// (set) Token: 0x06008F3D RID: 36669 RVA: 0x00252DF0 File Offset: 0x00250FF0
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x00252E30 File Offset: 0x00251030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259949, XrefRangeEnd = 259962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x00252E6C File Offset: 0x0025106C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259962, XrefRangeEnd = 259969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PauseMenu.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x00252EA8 File Offset: 0x002510A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259969, XrefRangeEnd = 259974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x00252EEC File Offset: 0x002510EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259974, XrefRangeEnd = 259977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x00252F20 File Offset: 0x00251120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259977, XrefRangeEnd = 259985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F43 RID: 36675 RVA: 0x00252F54 File Offset: 0x00251154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260047, RefRangeEnd = 260048, XrefRangeStart = 259985, XrefRangeEnd = 260047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F44 RID: 36676 RVA: 0x00252F88 File Offset: 0x00251188
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260104, RefRangeEnd = 260105, XrefRangeStart = 260048, XrefRangeEnd = 260104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F45 RID: 36677 RVA: 0x00252FBC File Offset: 0x002511BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260105, XrefRangeEnd = 260112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StuckButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F46 RID: 36678 RVA: 0x00252FF0 File Offset: 0x002511F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260112, XrefRangeEnd = 260115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PauseMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PauseMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F47 RID: 36679 RVA: 0x00045072 File Offset: 0x00043272
		public PauseMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BCE RID: 11214
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x0025302C File Offset: 0x0025122C
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x0004507B File Offset: 0x0004327B
		public unsafe bool _IsPaused_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr__IsPaused_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BCF RID: 11215
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x00253054 File Offset: 0x00251254
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x00045096 File Offset: 0x00043296
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD0 RID: 11216
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x00253084 File Offset: 0x00251284
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x000450B5 File Offset: 0x000432B5
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD1 RID: 11217
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x002530B4 File Offset: 0x002512B4
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x000450D4 File Offset: 0x000432D4
		public unsafe MainMenuScreen Screen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD2 RID: 11218
		// (get) Token: 0x06008F50 RID: 36688 RVA: 0x002530E4 File Offset: 0x002512E4
		// (set) Token: 0x06008F51 RID: 36689 RVA: 0x000450F3 File Offset: 0x000432F3
		public unsafe FeedbackForm FeedbackForm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeedbackForm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_FeedbackForm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BD3 RID: 11219
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x00253114 File Offset: 0x00251314
		// (set) Token: 0x06008F53 RID: 36691 RVA: 0x00045112 File Offset: 0x00043312
		public unsafe bool noActiveUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_noActiveUIElements)) = value;
			}
		}

		// Token: 0x17002BD4 RID: 11220
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x0025313C File Offset: 0x0025133C
		// (set) Token: 0x06008F55 RID: 36693 RVA: 0x0004512D File Offset: 0x0004332D
		public unsafe bool justPaused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justPaused)) = value;
			}
		}

		// Token: 0x17002BD5 RID: 11221
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x00253164 File Offset: 0x00251364
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x00045148 File Offset: 0x00043348
		public unsafe bool justResumed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_justResumed)) = value;
			}
		}

		// Token: 0x17002BD6 RID: 11222
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x0025318C File Offset: 0x0025138C
		// (set) Token: 0x06008F59 RID: 36697 RVA: 0x00045163 File Offset: 0x00043363
		public unsafe bool couldLook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_couldLook)) = value;
			}
		}

		// Token: 0x17002BD7 RID: 11223
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x002531B4 File Offset: 0x002513B4
		// (set) Token: 0x06008F5B RID: 36699 RVA: 0x0004517E File Offset: 0x0004337E
		public unsafe bool lockedMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_lockedMouse)) = value;
			}
		}

		// Token: 0x17002BD8 RID: 11224
		// (get) Token: 0x06008F5C RID: 36700 RVA: 0x002531DC File Offset: 0x002513DC
		// (set) Token: 0x06008F5D RID: 36701 RVA: 0x00045199 File Offset: 0x00043399
		public unsafe bool crosshairVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_crosshairVisible)) = value;
			}
		}

		// Token: 0x17002BD9 RID: 11225
		// (get) Token: 0x06008F5E RID: 36702 RVA: 0x00253204 File Offset: 0x00251404
		// (set) Token: 0x06008F5F RID: 36703 RVA: 0x000451B4 File Offset: 0x000433B4
		public unsafe bool hudVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_hudVisible)) = value;
			}
		}

		// Token: 0x17002BDA RID: 11226
		// (get) Token: 0x06008F60 RID: 36704 RVA: 0x0025322C File Offset: 0x0025142C
		// (set) Token: 0x06008F61 RID: 36705 RVA: 0x000451CF File Offset: 0x000433CF
		public unsafe UnityEvent onPause
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onPause), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BDB RID: 11227
		// (get) Token: 0x06008F62 RID: 36706 RVA: 0x0025325C File Offset: 0x0025145C
		// (set) Token: 0x06008F63 RID: 36707 RVA: 0x000451EE File Offset: 0x000433EE
		public unsafe UnityEvent onResume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PauseMenu.NativeFieldInfoPtr_onResume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060E7 RID: 24807
		private static readonly IntPtr NativeFieldInfoPtr__IsPaused_k__BackingField;

		// Token: 0x040060E8 RID: 24808
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040060E9 RID: 24809
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060EA RID: 24810
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x040060EB RID: 24811
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackForm;

		// Token: 0x040060EC RID: 24812
		private static readonly IntPtr NativeFieldInfoPtr_noActiveUIElements;

		// Token: 0x040060ED RID: 24813
		private static readonly IntPtr NativeFieldInfoPtr_justPaused;

		// Token: 0x040060EE RID: 24814
		private static readonly IntPtr NativeFieldInfoPtr_justResumed;

		// Token: 0x040060EF RID: 24815
		private static readonly IntPtr NativeFieldInfoPtr_couldLook;

		// Token: 0x040060F0 RID: 24816
		private static readonly IntPtr NativeFieldInfoPtr_lockedMouse;

		// Token: 0x040060F1 RID: 24817
		private static readonly IntPtr NativeFieldInfoPtr_crosshairVisible;

		// Token: 0x040060F2 RID: 24818
		private static readonly IntPtr NativeFieldInfoPtr_hudVisible;

		// Token: 0x040060F3 RID: 24819
		private static readonly IntPtr NativeFieldInfoPtr_onPause;

		// Token: 0x040060F4 RID: 24820
		private static readonly IntPtr NativeFieldInfoPtr_onResume;

		// Token: 0x040060F5 RID: 24821
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040060F6 RID: 24822
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPaused_Protected_set_Void_Boolean_0;

		// Token: 0x040060F7 RID: 24823
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040060F8 RID: 24824
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040060F9 RID: 24825
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060FA RID: 24826
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060FB RID: 24827
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040060FC RID: 24828
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x040060FD RID: 24829
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

		// Token: 0x040060FE RID: 24830
		private static readonly IntPtr NativeMethodInfoPtr_StuckButtonClicked_Public_Void_0;

		// Token: 0x040060FF RID: 24831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
