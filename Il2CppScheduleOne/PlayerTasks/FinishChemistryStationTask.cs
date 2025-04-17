using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000208 RID: 520
	public class FinishChemistryStationTask : Task
	{
		// Token: 0x06002B2C RID: 11052 RVA: 0x00017613 File Offset: 0x00015813
		// Note: this type is marked as 'beforefieldinit'.
		static FinishChemistryStationTask()
		{
			Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "FinishChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr);
			FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr, 100668144);
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x000F9264 File Offset: 0x000F7464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121544, XrefRangeEnd = 121545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinishChemistryStationTask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x0001764C File Offset: 0x0001584C
		public FinishChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001CA3 RID: 7331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
