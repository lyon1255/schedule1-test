using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x02000369 RID: 873
	public class Listener : MonoBehaviour
	{
		// Token: 0x06004450 RID: 17488 RVA: 0x00151EC8 File Offset: 0x001500C8
		// Note: this type is marked as 'beforefieldinit'.
		static Listener()
		{
			Il2CppClassPointerStore<Listener>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "Listener");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Listener>.NativeClassPtr);
			Listener.NativeFieldInfoPtr_listeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "listeners");
			Listener.NativeFieldInfoPtr_Sensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "Sensitivity");
			Listener.NativeFieldInfoPtr_HearingOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingOrigin");
			Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "<SquaredHearingRange>k__BackingField");
			Listener.NativeFieldInfoPtr_onNoiseHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Listener>.NativeClassPtr, "onNoiseHeard");
			Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671642);
			Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671643);
			Listener.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671644);
			Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671645);
			Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671646);
			Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671647);
			Listener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener>.NativeClassPtr, 100671648);
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x00151FE8 File Offset: 0x001501E8
		// (set) Token: 0x06004452 RID: 17490 RVA: 0x00152024 File Offset: 0x00150224
		public unsafe float SquaredHearingRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30020, RefRangeEnd = 30021, XrefRangeStart = 30020, XrefRangeEnd = 30021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30023, XrefRangeStart = 30021, XrefRangeEnd = 30023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x00152064 File Offset: 0x00150264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154849, XrefRangeEnd = 154856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00152098 File Offset: 0x00150298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154856, XrefRangeEnd = 154869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x001520CC File Offset: 0x001502CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154869, XrefRangeEnd = 154877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_OnDisable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00152100 File Offset: 0x00150300
		[CallerCount(0)]
		public unsafe void Notify(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00152144 File Offset: 0x00150344
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74368, XrefRangeEnd = 74372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Listener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00021592 File Offset: 0x0001F792
		public Listener(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014A6 RID: 5286
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x00152180 File Offset: 0x00150380
		// (set) Token: 0x0600445A RID: 17498 RVA: 0x0002159B File Offset: 0x0001F79B
		public unsafe static List<Listener> listeners
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Listener.NativeFieldInfoPtr_listeners, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Listener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Listener.NativeFieldInfoPtr_listeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600445B RID: 17499 RVA: 0x001521A8 File Offset: 0x001503A8
		// (set) Token: 0x0600445C RID: 17500 RVA: 0x000215AD File Offset: 0x0001F7AD
		public unsafe float Sensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_Sensitivity)) = value;
			}
		}

		// Token: 0x170014A8 RID: 5288
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x001521D0 File Offset: 0x001503D0
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x000215C8 File Offset: 0x0001F7C8
		public unsafe Transform HearingOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_HearingOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014A9 RID: 5289
		// (get) Token: 0x0600445F RID: 17503 RVA: 0x00152200 File Offset: 0x00150400
		// (set) Token: 0x06004460 RID: 17504 RVA: 0x000215E7 File Offset: 0x0001F7E7
		public unsafe float _SquaredHearingRange_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr__SquaredHearingRange_k__BackingField)) = value;
			}
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06004461 RID: 17505 RVA: 0x00152228 File Offset: 0x00150428
		// (set) Token: 0x06004462 RID: 17506 RVA: 0x00021602 File Offset: 0x0001F802
		public unsafe Listener.HearingEvent onNoiseHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener.HearingEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Listener.NativeFieldInfoPtr_onNoiseHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeFieldInfoPtr_listeners;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeFieldInfoPtr_Sensitivity;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeFieldInfoPtr_HearingOrigin;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeFieldInfoPtr__SquaredHearingRange_k__BackingField;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeFieldInfoPtr_onNoiseHeard;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeMethodInfoPtr_get_SquaredHearingRange_Public_get_Single_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeMethodInfoPtr_set_SquaredHearingRange_Protected_set_Void_Single_0;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Void_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_Notify_Public_Void_NoiseEvent_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000966 RID: 2406
		public sealed class HearingEvent : MulticastDelegate
		{
			// Token: 0x0600C938 RID: 51512 RVA: 0x0030B8FC File Offset: 0x00309AFC
			// Note: this type is marked as 'beforefieldinit'.
			static HearingEvent()
			{
				Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Listener>.NativeClassPtr, "HearingEvent");
				Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671650);
				Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671651);
				Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671652);
				Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr, 100671653);
			}

			// Token: 0x0600C939 RID: 51513 RVA: 0x0030B970 File Offset: 0x00309B70
			[CallerCount(632)]
			[CachedScanResults(RefRangeStart = 81883, RefRangeEnd = 82515, XrefRangeStart = 81883, XrefRangeEnd = 82515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HearingEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Listener.HearingEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C93A RID: 51514 RVA: 0x0030B9CC File Offset: 0x00309BCC
			[CallerCount(0)]
			public unsafe void Invoke(NoiseEvent nEvent)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C93B RID: 51515 RVA: 0x0030BA10 File Offset: 0x00309C10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NoiseEvent nEvent, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600C93C RID: 51516 RVA: 0x0030BA84 File Offset: 0x00309C84
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Listener.HearingEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C93D RID: 51517 RVA: 0x00061DFF File Offset: 0x0005FFFF
			public HearingEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C93E RID: 51518 RVA: 0x00061E08 File Offset: 0x00060008
			public static implicit operator Listener.HearingEvent(Action<NoiseEvent> A_0)
			{
				return DelegateSupport.ConvertDelegate<Listener.HearingEvent>(A_0);
			}

			// Token: 0x0600C93F RID: 51519 RVA: 0x00061E10 File Offset: 0x00060010
			public static Listener.HearingEvent operator +(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Listener.HearingEvent>();
			}

			// Token: 0x0600C940 RID: 51520 RVA: 0x00061E1E File Offset: 0x0006001E
			public static Listener.HearingEvent operator -(Listener.HearingEvent A_0, Listener.HearingEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Listener.HearingEvent>();
				}
				return result;
			}

			// Token: 0x04008835 RID: 34869
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008836 RID: 34870
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NoiseEvent_0;

			// Token: 0x04008837 RID: 34871
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_NoiseEvent_AsyncCallback_Object_0;

			// Token: 0x04008838 RID: 34872
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
