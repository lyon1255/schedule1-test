using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000554 RID: 1364
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x06007817 RID: 30743 RVA: 0x00207DFC File Offset: 0x00205FFC
		// Note: this type is marked as 'beforefieldinit'.
		static WheelRotator()
		{
			Il2CppClassPointerStore<WheelRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "WheelRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr);
			WheelRotator.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Radius");
			WheelRotator.NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Wheel");
			WheelRotator.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Flip");
			WheelRotator.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Controller");
			WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "AudioVolumeDivisor");
			WheelRotator.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "RotationAxis");
			WheelRotator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "lastFramePosition");
			WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678395);
			WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678396);
			WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678397);
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00207EF4 File Offset: 0x002060F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232179, XrefRangeEnd = 232187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00207F28 File Offset: 0x00206128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232187, XrefRangeEnd = 232201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00207F5C File Offset: 0x0020615C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232201, XrefRangeEnd = 232215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelRotator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00038E86 File Offset: 0x00037086
		public WheelRotator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x00207F98 File Offset: 0x00206198
		// (set) Token: 0x0600781D RID: 30749 RVA: 0x00038E8F File Offset: 0x0003708F
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x00207FC0 File Offset: 0x002061C0
		// (set) Token: 0x0600781F RID: 30751 RVA: 0x00038EAA File Offset: 0x000370AA
		public unsafe Transform Wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x00207FF0 File Offset: 0x002061F0
		// (set) Token: 0x06007821 RID: 30753 RVA: 0x00038EC9 File Offset: 0x000370C9
		public unsafe bool Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x00208018 File Offset: 0x00206218
		// (set) Token: 0x06007823 RID: 30755 RVA: 0x00038EE4 File Offset: 0x000370E4
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06007824 RID: 30756 RVA: 0x00208048 File Offset: 0x00206248
		// (set) Token: 0x06007825 RID: 30757 RVA: 0x00038F03 File Offset: 0x00037103
		public unsafe float AudioVolumeDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor)) = value;
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x00208070 File Offset: 0x00206270
		// (set) Token: 0x06007827 RID: 30759 RVA: 0x00038F1E File Offset: 0x0003711E
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x00208098 File Offset: 0x00206298
		// (set) Token: 0x06007829 RID: 30761 RVA: 0x00038F39 File Offset: 0x00037139
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x040051DF RID: 20959
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x040051E0 RID: 20960
		private static readonly IntPtr NativeFieldInfoPtr_Wheel;

		// Token: 0x040051E1 RID: 20961
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x040051E2 RID: 20962
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x040051E3 RID: 20963
		private static readonly IntPtr NativeFieldInfoPtr_AudioVolumeDivisor;

		// Token: 0x040051E4 RID: 20964
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x040051E5 RID: 20965
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040051E6 RID: 20966
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040051E7 RID: 20967
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040051E8 RID: 20968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
