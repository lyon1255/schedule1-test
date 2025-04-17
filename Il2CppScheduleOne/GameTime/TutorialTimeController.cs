using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000195 RID: 405
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x06002181 RID: 8577 RVA: 0x000D9378 File Offset: 0x000D7578
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialTimeController()
		{
			Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TutorialTimeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr);
			TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "TimeProgressionCurve");
			TutorialTimeController.NativeFieldInfoPtr_KeyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrames");
			TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "currentKeyFrameIndex");
			TutorialTimeController.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "disabled");
			TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667090);
			TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667091);
			TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667092);
			TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667093);
			TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667094);
			TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667095);
			TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667096);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000D9484 File Offset: 0x000D7684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110443, XrefRangeEnd = 110461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000D94B8 File Offset: 0x000D76B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110461, XrefRangeEnd = 110479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000D94EC File Offset: 0x000D76EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110479, XrefRangeEnd = 110494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000D9520 File Offset: 0x000D7720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110494, XrefRangeEnd = 110498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentKeyFrameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000D955C File Offset: 0x000D775C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110498, XrefRangeEnd = 110506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000D9590 File Offset: 0x000D7790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110506, XrefRangeEnd = 110511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000D95C4 File Offset: 0x000D77C4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialTimeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00012B2A File Offset: 0x00010D2A
		public TutorialTimeController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600218A RID: 8586 RVA: 0x000D9600 File Offset: 0x000D7800
		// (set) Token: 0x0600218B RID: 8587 RVA: 0x00012B33 File Offset: 0x00010D33
		public unsafe AnimationCurve TimeProgressionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x000D9630 File Offset: 0x000D7830
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x00012B52 File Offset: 0x00010D52
		public unsafe Il2CppReferenceArray<TutorialTimeController.KeyFrame> KeyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialTimeController.KeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000D9660 File Offset: 0x000D7860
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x00012B71 File Offset: 0x00010D71
		public unsafe int currentKeyFrameIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex)) = value;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000D9688 File Offset: 0x000D7888
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x00012B8C File Offset: 0x00010D8C
		public unsafe bool disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled)) = value;
			}
		}

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeFieldInfoPtr_TimeProgressionCurve;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeFieldInfoPtr_KeyFrames;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeFieldInfoPtr_currentKeyFrameIndex;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeFieldInfoPtr_disabled;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0;

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008BE RID: 2238
		[Serializable]
		public sealed class KeyFrame : ValueType
		{
			// Token: 0x0600C386 RID: 50054 RVA: 0x002FAE2C File Offset: 0x002F902C
			// Note: this type is marked as 'beforefieldinit'.
			static KeyFrame()
			{
				Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr);
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Time");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "SpeedMultiplier");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Note");
			}

			// Token: 0x0600C387 RID: 50055 RVA: 0x0005F2E8 File Offset: 0x0005D4E8
			public KeyFrame(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C388 RID: 50056 RVA: 0x0005F2F1 File Offset: 0x0005D4F1
			public KeyFrame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr))
			{
			}

			// Token: 0x17003D11 RID: 15633
			// (get) Token: 0x0600C389 RID: 50057 RVA: 0x002FAE94 File Offset: 0x002F9094
			// (set) Token: 0x0600C38A RID: 50058 RVA: 0x0005F303 File Offset: 0x0005D503
			public unsafe int Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time)) = value;
				}
			}

			// Token: 0x17003D12 RID: 15634
			// (get) Token: 0x0600C38B RID: 50059 RVA: 0x002FAEBC File Offset: 0x002F90BC
			// (set) Token: 0x0600C38C RID: 50060 RVA: 0x0005F31E File Offset: 0x0005D51E
			public unsafe float SpeedMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier)) = value;
				}
			}

			// Token: 0x17003D13 RID: 15635
			// (get) Token: 0x0600C38D RID: 50061 RVA: 0x002FAEE4 File Offset: 0x002F90E4
			// (set) Token: 0x0600C38E RID: 50062 RVA: 0x0005F339 File Offset: 0x0005D539
			public unsafe string Note
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008493 RID: 33939
			private static readonly IntPtr NativeFieldInfoPtr_Time;

			// Token: 0x04008494 RID: 33940
			private static readonly IntPtr NativeFieldInfoPtr_SpeedMultiplier;

			// Token: 0x04008495 RID: 33941
			private static readonly IntPtr NativeFieldInfoPtr_Note;
		}
	}
}
