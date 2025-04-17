using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CA RID: 458
	[Serializable]
	public class QuestWindowConfig : Object
	{
		// Token: 0x06002709 RID: 9993 RVA: 0x000EAD28 File Offset: 0x000E8F28
		// Note: this type is marked as 'beforefieldinit'.
		static QuestWindowConfig()
		{
			Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestWindowConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr);
			QuestWindowConfig.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "IsEnabled");
			QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowStartTime");
			QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowEndTime");
			QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, 100667655);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000EADA8 File Offset: 0x000E8FA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 117619, RefRangeEnd = 117625, XrefRangeStart = 117618, XrefRangeEnd = 117619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestWindowConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x00015A1A File Offset: 0x00013C1A
		public QuestWindowConfig(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D52 RID: 3410
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x000EADE4 File Offset: 0x000E8FE4
		// (set) Token: 0x0600270D RID: 9997 RVA: 0x00015A23 File Offset: 0x00013C23
		public unsafe bool IsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled)) = value;
			}
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x000EAE0C File Offset: 0x000E900C
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x00015A3E File Offset: 0x00013C3E
		public unsafe int WindowStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime)) = value;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x000EAE34 File Offset: 0x000E9034
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x00015A59 File Offset: 0x00013C59
		public unsafe int WindowEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime)) = value;
			}
		}

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeFieldInfoPtr_WindowStartTime;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeFieldInfoPtr_WindowEndTime;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
