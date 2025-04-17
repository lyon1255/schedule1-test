using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C4 RID: 452
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x06002698 RID: 9880 RVA: 0x000E99BC File Offset: 0x000E7BBC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_TheDeepEnd()
		{
			Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_TheDeepEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr);
			Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MEETING_REMINDER_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "KIDNAP_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "kidnapQueued");
			Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "meetingSetup");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Thomas");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Gate");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Switch");
			Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MeetingTeleportPoint");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingCall");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingTrigger");
			Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667609);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667610);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667611);
			Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667612);
			Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667613);
			Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667614);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667615);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667616);
			Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667617);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667618);
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x000E9B7C File Offset: 0x000E7D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117187, XrefRangeEnd = 117234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x000E9BB8 File Offset: 0x000E7DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117234, XrefRangeEnd = 117236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000E9C04 File Offset: 0x000E7E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117249, RefRangeEnd = 117251, XrefRangeStart = 117236, XrefRangeEnd = 117249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFirstMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x000E9C38 File Offset: 0x000E7E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117251, XrefRangeEnd = 117274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000E9C7C File Offset: 0x000E7E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117274, XrefRangeEnd = 117300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117300, XrefRangeEnd = 117307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeforeSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000E9CE4 File Offset: 0x000E7EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117307, XrefRangeEnd = 117320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000E9D18 File Offset: 0x000E7F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117320, XrefRangeEnd = 117325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000E9D80 File Offset: 0x000E7F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117325, XrefRangeEnd = 117329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_TheDeepEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000E9DBC File Offset: 0x000E7FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117329, XrefRangeEnd = 117334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0001561B File Offset: 0x0001381B
		public Quest_TheDeepEnd(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000E9DFC File Offset: 0x000E7FFC
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x00015624 File Offset: 0x00013824
		public unsafe static float MEETING_REMINDER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000E9E18 File Offset: 0x000E8018
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x00015632 File Offset: 0x00013832
		public unsafe static float KIDNAP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000E9E34 File Offset: 0x000E8034
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x00015640 File Offset: 0x00013840
		public unsafe bool kidnapQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued)) = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x000E9E5C File Offset: 0x000E805C
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x0001565B File Offset: 0x0001385B
		public unsafe bool meetingSetup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup)) = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000E9E84 File Offset: 0x000E8084
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x00015676 File Offset: 0x00013876
		public unsafe Thomas Thomas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000E9EB4 File Offset: 0x000E80B4
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x00015695 File Offset: 0x00013895
		public unsafe ManorGate Gate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000E9EE4 File Offset: 0x000E80E4
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x000156B4 File Offset: 0x000138B4
		public unsafe ModularSwitch Switch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x000E9F14 File Offset: 0x000E8114
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x000156D3 File Offset: 0x000138D3
		public unsafe Transform MeetingTeleportPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x000E9F44 File Offset: 0x000E8144
		// (set) Token: 0x060026B5 RID: 9909 RVA: 0x000156F2 File Offset: 0x000138F2
		public unsafe PhoneCallData PostMeetingCall
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060026B6 RID: 9910 RVA: 0x000E9F74 File Offset: 0x000E8174
		// (set) Token: 0x060026B7 RID: 9911 RVA: 0x00015711 File Offset: 0x00013911
		public unsafe SystemTriggerObject PostMeetingTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTriggerObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_MEETING_REMINDER_TIME;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_KIDNAP_TIME;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_kidnapQueued;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_meetingSetup;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_MeetingTeleportPoint;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingCall;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_PostMeetingTrigger;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeMethodInfoPtr_BeforeSleep_Private_Void_0;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeMethodInfoPtr_SleepFadeOut_Private_Void_0;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020008D2 RID: 2258
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C413 RID: 50195 RVA: 0x002FC738 File Offset: 0x002FA938
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>1__state");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>2__current");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>4__this");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667619);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667620);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667621);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667622);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667623);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667624);
			}

			// Token: 0x0600C414 RID: 50196 RVA: 0x002FC818 File Offset: 0x002FAA18
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C415 RID: 50197 RVA: 0x002FC860 File Offset: 0x002FAA60
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C416 RID: 50198 RVA: 0x002FC894 File Offset: 0x002FAA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117152, XrefRangeEnd = 117173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D36 RID: 15670
			// (get) Token: 0x0600C417 RID: 50199 RVA: 0x002FC8D0 File Offset: 0x002FAAD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C418 RID: 50200 RVA: 0x002FC910 File Offset: 0x002FAB10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117173, XrefRangeEnd = 117178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D37 RID: 15671
			// (get) Token: 0x0600C419 RID: 50201 RVA: 0x002FC944 File Offset: 0x002FAB44
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C41A RID: 50202 RVA: 0x0005F6F7 File Offset: 0x0005D8F7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D33 RID: 15667
			// (get) Token: 0x0600C41B RID: 50203 RVA: 0x002FC984 File Offset: 0x002FAB84
			// (set) Token: 0x0600C41C RID: 50204 RVA: 0x0005F700 File Offset: 0x0005D900
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D34 RID: 15668
			// (get) Token: 0x0600C41D RID: 50205 RVA: 0x002FC9AC File Offset: 0x002FABAC
			// (set) Token: 0x0600C41E RID: 50206 RVA: 0x0005F71B File Offset: 0x0005D91B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D35 RID: 15669
			// (get) Token: 0x0600C41F RID: 50207 RVA: 0x002FC9DC File Offset: 0x002FABDC
			// (set) Token: 0x0600C420 RID: 50208 RVA: 0x0005F73A File Offset: 0x0005D93A
			public unsafe Quest_TheDeepEnd __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084E4 RID: 34020
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040084E5 RID: 34021
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040084E6 RID: 34022
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040084E7 RID: 34023
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040084E8 RID: 34024
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084E9 RID: 34025
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040084EA RID: 34026
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040084EB RID: 34027
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040084EC RID: 34028
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008D3 RID: 2259
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C421 RID: 50209 RVA: 0x002FCA0C File Offset: 0x002FAC0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr);
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9");
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9__13_1");
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667626);
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667627);
			}

			// Token: 0x0600C422 RID: 50210 RVA: 0x002FCA88 File Offset: 0x002FAC88
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C423 RID: 50211 RVA: 0x002FCAC4 File Offset: 0x002FACC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117178, XrefRangeEnd = 117187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ThomasDialogueNodeDisplayed_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C424 RID: 50212 RVA: 0x0005F759 File Offset: 0x0005D959
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D38 RID: 15672
			// (get) Token: 0x0600C425 RID: 50213 RVA: 0x002FCB00 File Offset: 0x002FAD00
			// (set) Token: 0x0600C426 RID: 50214 RVA: 0x0005F762 File Offset: 0x0005D962
			public unsafe static Quest_TheDeepEnd.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D39 RID: 15673
			// (get) Token: 0x0600C427 RID: 50215 RVA: 0x002FCB28 File Offset: 0x002FAD28
			// (set) Token: 0x0600C428 RID: 50216 RVA: 0x0005F774 File Offset: 0x0005D974
			public unsafe static Func<bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084ED RID: 34029
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084EE RID: 34030
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040084EF RID: 34031
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084F0 RID: 34032
			private static readonly IntPtr NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0;
		}
	}
}
