using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000177 RID: 375
	public class VisionEvent : Object
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x000CEA40 File Offset: 0x000CCC40
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEvent()
		{
			Il2CppClassPointerStore<VisionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr);
			VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "NOTICE_DROP_THRESHOLD");
			VisionEvent.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Target>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<State>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<Owner>k__BackingField");
			VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "<FullNoticeTime>k__BackingField");
			VisionEvent.NativeFieldInfoPtr_timeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "timeSinceSighted");
			VisionEvent.NativeFieldInfoPtr_currentNoticeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, "currentNoticeTime");
			VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666733);
			VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666734);
			VisionEvent.NativeMethodInfoPtr_get_State_Public_get_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666735);
			VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666736);
			VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666737);
			VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666738);
			VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666739);
			VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666740);
			VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666741);
			VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666742);
			VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666743);
			VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr, 100666744);
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x000CEBEC File Offset: 0x000CCDEC
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x000CEC2C File Offset: 0x000CCE2C
		public unsafe Player Target
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x000CEC70 File Offset: 0x000CCE70
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x000CECB0 File Offset: 0x000CCEB0
		public unsafe PlayerVisualState.VisualState State
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_State_Public_get_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x000CECF4 File Offset: 0x000CCEF4
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x000CED34 File Offset: 0x000CCF34
		public unsafe VisionCone Owner
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000CED78 File Offset: 0x000CCF78
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x000CEDB4 File Offset: 0x000CCFB4
		public unsafe float FullNoticeTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x000CEDF4 File Offset: 0x000CCFF4
		public unsafe float NormalizedNoticeLevel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107179, RefRangeEnd = 107182, XrefRangeStart = 107179, XrefRangeEnd = 107179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x000CEE30 File Offset: 0x000CD030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107200, RefRangeEnd = 107201, XrefRangeStart = 107182, XrefRangeEnd = 107200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEvent(VisionCone _owner, Player _target, PlayerVisualState.VisualState _state, float _noticeTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEvent>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_owner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _noticeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x000CEEB0 File Offset: 0x000CD0B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107217, RefRangeEnd = 107219, XrefRangeStart = 107201, XrefRangeEnd = 107217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEvent(float visionDeltaThisFrame, float tickTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visionDeltaThisFrame;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tickTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x000CEEFC File Offset: 0x000CD0FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107221, RefRangeEnd = 107226, XrefRangeStart = 107219, XrefRangeEnd = 107221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEvent.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000111F0 File Offset: 0x0000F3F0
		public VisionEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x000CEF30 File Offset: 0x000CD130
		// (set) Token: 0x06001E60 RID: 7776 RVA: 0x000111F9 File Offset: 0x0000F3F9
		public unsafe static float NOTICE_DROP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisionEvent.NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x000CEF4C File Offset: 0x000CD14C
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x00011207 File Offset: 0x0000F407
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x000CEF7C File Offset: 0x000CD17C
		// (set) Token: 0x06001E64 RID: 7780 RVA: 0x00011226 File Offset: 0x0000F426
		public unsafe PlayerVisualState.VisualState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisualState.VisualState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__State_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x000CEFAC File Offset: 0x000CD1AC
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x00011245 File Offset: 0x0000F445
		public unsafe VisionCone _Owner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__Owner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x000CEFDC File Offset: 0x000CD1DC
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x00011264 File Offset: 0x0000F464
		public unsafe float _FullNoticeTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr__FullNoticeTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x000CF004 File Offset: 0x000CD204
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x0001127F File Offset: 0x0000F47F
		public unsafe float timeSinceSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_timeSinceSighted)) = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x000CF02C File Offset: 0x000CD22C
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x0001129A File Offset: 0x0000F49A
		public unsafe float currentNoticeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEvent.NativeFieldInfoPtr_currentNoticeTime)) = value;
			}
		}

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_NOTICE_DROP_THRESHOLD;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr__Owner_k__BackingField;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeFieldInfoPtr__FullNoticeTime_k__BackingField;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceSighted;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr_currentNoticeTime;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_VisualState_0;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_VisualState_0;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_VisionCone_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_set_Owner_Protected_set_Void_VisionCone_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_get_FullNoticeTime_Public_get_Single_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_set_FullNoticeTime_Protected_set_Void_Single_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedNoticeLevel_Public_get_Single_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_VisionCone_Player_VisualState_Single_0;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEvent_Public_Void_Single_Single_0;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;
	}
}
