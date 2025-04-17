using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004AF RID: 1199
	[Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x060069A7 RID: 27047 RVA: 0x001D8E5C File Offset: 0x001D705C
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallData()
		{
			Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "PhoneCallData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr);
			PhoneCallData.NativeFieldInfoPtr_CallerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "CallerID");
			PhoneCallData.NativeFieldInfoPtr_Stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stages");
			PhoneCallData.NativeFieldInfoPtr_onCallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "onCallCompleted");
			PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676713);
			PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100676714);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x001D8EF0 File Offset: 0x001D70F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Completed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x001D8F24 File Offset: 0x001D7124
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 88913, RefRangeEnd = 88925, XrefRangeStart = 88913, XrefRangeEnd = 88925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x00031EF0 File Offset: 0x000300F0
		public PhoneCallData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x060069AB RID: 27051 RVA: 0x001D8F60 File Offset: 0x001D7160
		// (set) Token: 0x060069AC RID: 27052 RVA: 0x00031EF9 File Offset: 0x000300F9
		public unsafe CallerID CallerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x060069AD RID: 27053 RVA: 0x001D8F90 File Offset: 0x001D7190
		// (set) Token: 0x060069AE RID: 27054 RVA: 0x00031F18 File Offset: 0x00030118
		public unsafe Il2CppReferenceArray<PhoneCallData.Stage> Stages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneCallData.Stage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x060069AF RID: 27055 RVA: 0x001D8FC0 File Offset: 0x001D71C0
		// (set) Token: 0x060069B0 RID: 27056 RVA: 0x00031F37 File Offset: 0x00030137
		public unsafe UnityEvent onCallCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004860 RID: 18528
		private static readonly IntPtr NativeFieldInfoPtr_CallerID;

		// Token: 0x04004861 RID: 18529
		private static readonly IntPtr NativeFieldInfoPtr_Stages;

		// Token: 0x04004862 RID: 18530
		private static readonly IntPtr NativeFieldInfoPtr_onCallCompleted;

		// Token: 0x04004863 RID: 18531
		private static readonly IntPtr NativeMethodInfoPtr_Completed_Public_Void_0;

		// Token: 0x04004864 RID: 18532
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A51 RID: 2641
		[Serializable]
		public class Stage : Il2CppSystem.Object
		{
			// Token: 0x0600D03B RID: 53307 RVA: 0x0031F510 File Offset: 0x0031D710
			// Note: this type is marked as 'beforefieldinit'.
			static Stage()
			{
				Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr);
				PhoneCallData.Stage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "Text");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnStartTriggers");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnDoneTriggers");
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676715);
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676716);
				PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100676717);
			}

			// Token: 0x0600D03C RID: 53308 RVA: 0x0031F5B4 File Offset: 0x0031D7B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 212920, RefRangeEnd = 212922, XrefRangeStart = 212918, XrefRangeEnd = 212920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageStart()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03D RID: 53309 RVA: 0x0031F5E8 File Offset: 0x0031D7E8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 212924, RefRangeEnd = 212927, XrefRangeStart = 212922, XrefRangeEnd = 212924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03E RID: 53310 RVA: 0x0031F61C File Offset: 0x0031D81C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D03F RID: 53311 RVA: 0x00065552 File Offset: 0x00063752
			public Stage(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040AD RID: 16557
			// (get) Token: 0x0600D040 RID: 53312 RVA: 0x0031F658 File Offset: 0x0031D858
			// (set) Token: 0x0600D041 RID: 53313 RVA: 0x0006555B File Offset: 0x0006375B
			public unsafe string Text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040AE RID: 16558
			// (get) Token: 0x0600D042 RID: 53314 RVA: 0x0031F680 File Offset: 0x0031D880
			// (set) Token: 0x0600D043 RID: 53315 RVA: 0x0006557A File Offset: 0x0006377A
			public unsafe Il2CppReferenceArray<SystemTrigger> OnStartTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040AF RID: 16559
			// (get) Token: 0x0600D044 RID: 53316 RVA: 0x0031F6B0 File Offset: 0x0031D8B0
			// (set) Token: 0x0600D045 RID: 53317 RVA: 0x00065599 File Offset: 0x00063799
			public unsafe Il2CppReferenceArray<SystemTrigger> OnDoneTriggers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C88 RID: 35976
			private static readonly IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x04008C89 RID: 35977
			private static readonly IntPtr NativeFieldInfoPtr_OnStartTriggers;

			// Token: 0x04008C8A RID: 35978
			private static readonly IntPtr NativeFieldInfoPtr_OnDoneTriggers;

			// Token: 0x04008C8B RID: 35979
			private static readonly IntPtr NativeMethodInfoPtr_OnStageStart_Public_Void_0;

			// Token: 0x04008C8C RID: 35980
			private static readonly IntPtr NativeMethodInfoPtr_OnStageEnd_Public_Void_0;

			// Token: 0x04008C8D RID: 35981
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
