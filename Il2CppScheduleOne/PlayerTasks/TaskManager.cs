using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000203 RID: 515
	public class TaskManager : Singleton<TaskManager>
	{
		// Token: 0x06002ACB RID: 10955 RVA: 0x000F7DF4 File Offset: 0x000F5FF4
		// Note: this type is marked as 'beforefieldinit'.
		static TaskManager()
		{
			Il2CppClassPointerStore<TaskManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "TaskManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskManager>.NativeClassPtr);
			TaskManager.NativeFieldInfoPtr_currentTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "currentTask");
			TaskManager.NativeFieldInfoPtr_TaskCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "TaskCompleteSound");
			TaskManager.NativeFieldInfoPtr_OnTaskStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, "OnTaskStarted");
			TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668089);
			TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668090);
			TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668091);
			TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668092);
			TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668093);
			TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668094);
			TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668095);
			TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskManager>.NativeClassPtr, 100668096);
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x000F7F00 File Offset: 0x000F6100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120974, XrefRangeEnd = 120987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x000F7F3C File Offset: 0x000F613C
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000F7F78 File Offset: 0x000F6178
		[CallerCount(0)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000F7FBC File Offset: 0x000F61BC
		[CallerCount(0)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000F7FF8 File Offset: 0x000F61F8
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000F8034 File Offset: 0x000F6234
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112617, RefRangeEnd = 112621, XrefRangeStart = 112617, XrefRangeEnd = 112621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTaskCompleteSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000F8068 File Offset: 0x000F6268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120987, XrefRangeEnd = 120988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr_StartTask_Public_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000F80AC File Offset: 0x000F62AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120988, XrefRangeEnd = 120991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x00017372 File Offset: 0x00015572
		public TaskManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000F80E8 File Offset: 0x000F62E8
		// (set) Token: 0x06002AD6 RID: 10966 RVA: 0x0001737B File Offset: 0x0001557B
		public unsafe Task currentTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_currentTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_currentTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002AD7 RID: 10967 RVA: 0x000F8118 File Offset: 0x000F6318
		// (set) Token: 0x06002AD8 RID: 10968 RVA: 0x0001739A File Offset: 0x0001559A
		public unsafe AudioSourceController TaskCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_TaskCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06002AD9 RID: 10969 RVA: 0x000F8148 File Offset: 0x000F6348
		// (set) Token: 0x06002ADA RID: 10970 RVA: 0x000173B9 File Offset: 0x000155B9
		public unsafe Action<Task> OnTaskStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskManager.NativeFieldInfoPtr_OnTaskStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeFieldInfoPtr_currentTask;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeFieldInfoPtr_TaskCompleteSound;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeFieldInfoPtr_OnTaskStarted;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_PlayTaskCompleteSound_Public_Void_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_StartTask_Public_Void_Task_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
