using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000668 RID: 1640
	public class TaskManagerUI : Singleton<TaskManagerUI>
	{
		// Token: 0x0600928D RID: 37517 RVA: 0x0025CA48 File Offset: 0x0025AC48
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManagerUI()
		{
			Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TaskManagerUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr);
			TaskManagerUI.NativeFieldInfoPtr_textShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "textShown");
			TaskManagerUI.NativeFieldInfoPtr_inputPromptUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "inputPromptUI");
			TaskManagerUI.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "canvas");
			TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "multiGrabIndicator");
			TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, "PackagingStationMK2TutorialDone");
			TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681492);
			TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681493);
			TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681494);
			TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681495);
			TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr, 100681496);
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x0025CB40 File Offset: 0x0025AD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264574, XrefRangeEnd = 264580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x0025CB7C File Offset: 0x0025AD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264580, XrefRangeEnd = 264605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x0025CBB8 File Offset: 0x0025ADB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264605, XrefRangeEnd = 264621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateInstructionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManagerUI.NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009291 RID: 37521 RVA: 0x0025CBF4 File Offset: 0x0025ADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264621, XrefRangeEnd = 264646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TaskStarted(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x0025CC38 File Offset: 0x0025AE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264646, XrefRangeEnd = 264649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManagerUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManagerUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManagerUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x00046EC4 File Offset: 0x000450C4
		public TaskManagerUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x06009294 RID: 37524 RVA: 0x0025CC74 File Offset: 0x0025AE74
		// (set) Token: 0x06009295 RID: 37525 RVA: 0x00046ECD File Offset: 0x000450CD
		public unsafe bool textShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_textShown)) = value;
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06009296 RID: 37526 RVA: 0x0025CC9C File Offset: 0x0025AE9C
		// (set) Token: 0x06009297 RID: 37527 RVA: 0x00046EE8 File Offset: 0x000450E8
		public unsafe GenericUIScreen inputPromptUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_inputPromptUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06009298 RID: 37528 RVA: 0x0025CCCC File Offset: 0x0025AECC
		// (set) Token: 0x06009299 RID: 37529 RVA: 0x00046F07 File Offset: 0x00045107
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600929A RID: 37530 RVA: 0x0025CCFC File Offset: 0x0025AEFC
		// (set) Token: 0x0600929B RID: 37531 RVA: 0x00046F26 File Offset: 0x00045126
		public unsafe RectTransform multiGrabIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_multiGrabIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x0600929C RID: 37532 RVA: 0x0025CD2C File Offset: 0x0025AF2C
		// (set) Token: 0x0600929D RID: 37533 RVA: 0x00046F45 File Offset: 0x00045145
		public unsafe GenericUIScreen PackagingStationMK2TutorialDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericUIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManagerUI.NativeFieldInfoPtr_PackagingStationMK2TutorialDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006301 RID: 25345
		private static readonly IntPtr NativeFieldInfoPtr_textShown;

		// Token: 0x04006302 RID: 25346
		private static readonly IntPtr NativeFieldInfoPtr_inputPromptUI;

		// Token: 0x04006303 RID: 25347
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006304 RID: 25348
		private static readonly IntPtr NativeFieldInfoPtr_multiGrabIndicator;

		// Token: 0x04006305 RID: 25349
		private static readonly IntPtr NativeFieldInfoPtr_PackagingStationMK2TutorialDone;

		// Token: 0x04006306 RID: 25350
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006307 RID: 25351
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006308 RID: 25352
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstructionLabel_Protected_Virtual_New_Void_0;

		// Token: 0x04006309 RID: 25353
		private static readonly IntPtr NativeMethodInfoPtr_TaskStarted_Private_Void_Task_0;

		// Token: 0x0400630A RID: 25354
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
