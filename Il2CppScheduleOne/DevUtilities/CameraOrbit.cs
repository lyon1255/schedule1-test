using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000451 RID: 1105
	public class CameraOrbit : MonoBehaviour
	{
		// Token: 0x06006001 RID: 24577 RVA: 0x001B7E0C File Offset: 0x001B600C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraOrbit()
		{
			Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CameraOrbit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr);
			CameraOrbit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "target");
			CameraOrbit.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "cam");
			CameraOrbit.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "raycaster");
			CameraOrbit.NativeFieldInfoPtr_LookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "LookAt");
			CameraOrbit.NativeFieldInfoPtr_targetdistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetdistance");
			CameraOrbit.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "xSpeed");
			CameraOrbit.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ySpeed");
			CameraOrbit.NativeFieldInfoPtr_sideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "sideOffset");
			CameraOrbit.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMinLimit");
			CameraOrbit.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "yMaxLimit");
			CameraOrbit.NativeFieldInfoPtr_distanceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMin");
			CameraOrbit.NativeFieldInfoPtr_distanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distanceMax");
			CameraOrbit.NativeFieldInfoPtr_ScrollSensativity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "ScrollSensativity");
			CameraOrbit.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "rb");
			CameraOrbit.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "x");
			CameraOrbit.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "y");
			CameraOrbit.NativeFieldInfoPtr_targetx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targetx");
			CameraOrbit.NativeFieldInfoPtr_targety = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "targety");
			CameraOrbit.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "distance");
			CameraOrbit.NativeFieldInfoPtr_hoveringUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, "hoveringUI");
			CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675537);
			CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675538);
			CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675539);
			CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675540);
			CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr, 100675541);
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x001B8030 File Offset: 0x001B6230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198785, XrefRangeEnd = 198796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x001B8064 File Offset: 0x001B6264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198796, XrefRangeEnd = 198815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x001B8098 File Offset: 0x001B6298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198815, XrefRangeEnd = 198878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x001B80CC File Offset: 0x001B62CC
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x001B8128 File Offset: 0x001B6328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198878, XrefRangeEnd = 198879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraOrbit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraOrbit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraOrbit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x0002D52A File Offset: 0x0002B72A
		public CameraOrbit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x001B8164 File Offset: 0x001B6364
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x0002D533 File Offset: 0x0002B733
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x001B8194 File Offset: 0x001B6394
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x0002D552 File Offset: 0x0002B752
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x001B81C4 File Offset: 0x001B63C4
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x0002D571 File Offset: 0x0002B771
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x0600600E RID: 24590 RVA: 0x001B81F4 File Offset: 0x001B63F4
		// (set) Token: 0x0600600F RID: 24591 RVA: 0x0002D590 File Offset: 0x0002B790
		public unsafe AvatarLookController LookAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarLookController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_LookAt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06006010 RID: 24592 RVA: 0x001B8224 File Offset: 0x001B6424
		// (set) Token: 0x06006011 RID: 24593 RVA: 0x0002D5AF File Offset: 0x0002B7AF
		public unsafe float targetdistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetdistance)) = value;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x001B824C File Offset: 0x001B644C
		// (set) Token: 0x06006013 RID: 24595 RVA: 0x0002D5CA File Offset: 0x0002B7CA
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x001B8274 File Offset: 0x001B6474
		// (set) Token: 0x06006015 RID: 24597 RVA: 0x0002D5E5 File Offset: 0x0002B7E5
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x001B829C File Offset: 0x001B649C
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x0002D600 File Offset: 0x0002B800
		public unsafe float sideOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_sideOffset)) = value;
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x001B82C4 File Offset: 0x001B64C4
		// (set) Token: 0x06006019 RID: 24601 RVA: 0x0002D61B File Offset: 0x0002B81B
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x001B82EC File Offset: 0x001B64EC
		// (set) Token: 0x0600601B RID: 24603 RVA: 0x0002D636 File Offset: 0x0002B836
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x001B8314 File Offset: 0x001B6514
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x0002D651 File Offset: 0x0002B851
		public unsafe float distanceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMin)) = value;
			}
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x001B833C File Offset: 0x001B653C
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x0002D66C File Offset: 0x0002B86C
		public unsafe float distanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distanceMax)) = value;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06006020 RID: 24608 RVA: 0x001B8364 File Offset: 0x001B6564
		// (set) Token: 0x06006021 RID: 24609 RVA: 0x0002D687 File Offset: 0x0002B887
		public unsafe float ScrollSensativity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_ScrollSensativity)) = value;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06006022 RID: 24610 RVA: 0x001B838C File Offset: 0x001B658C
		// (set) Token: 0x06006023 RID: 24611 RVA: 0x0002D6A2 File Offset: 0x0002B8A2
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x001B83BC File Offset: 0x001B65BC
		// (set) Token: 0x06006025 RID: 24613 RVA: 0x0002D6C1 File Offset: 0x0002B8C1
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x001B83E4 File Offset: 0x001B65E4
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x0002D6DC File Offset: 0x0002B8DC
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06006028 RID: 24616 RVA: 0x001B840C File Offset: 0x001B660C
		// (set) Token: 0x06006029 RID: 24617 RVA: 0x0002D6F7 File Offset: 0x0002B8F7
		public unsafe float targetx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targetx)) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x0600602A RID: 24618 RVA: 0x001B8434 File Offset: 0x001B6634
		// (set) Token: 0x0600602B RID: 24619 RVA: 0x0002D712 File Offset: 0x0002B912
		public unsafe float targety
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_targety)) = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x0600602C RID: 24620 RVA: 0x001B845C File Offset: 0x001B665C
		// (set) Token: 0x0600602D RID: 24621 RVA: 0x0002D72D File Offset: 0x0002B92D
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x0600602E RID: 24622 RVA: 0x001B8484 File Offset: 0x001B6684
		// (set) Token: 0x0600602F RID: 24623 RVA: 0x0002D748 File Offset: 0x0002B948
		public unsafe bool hoveringUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraOrbit.NativeFieldInfoPtr_hoveringUI)) = value;
			}
		}

		// Token: 0x04004193 RID: 16787
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04004194 RID: 16788
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04004195 RID: 16789
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04004196 RID: 16790
		private static readonly IntPtr NativeFieldInfoPtr_LookAt;

		// Token: 0x04004197 RID: 16791
		private static readonly IntPtr NativeFieldInfoPtr_targetdistance;

		// Token: 0x04004198 RID: 16792
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004199 RID: 16793
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x0400419A RID: 16794
		private static readonly IntPtr NativeFieldInfoPtr_sideOffset;

		// Token: 0x0400419B RID: 16795
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x0400419C RID: 16796
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x0400419D RID: 16797
		private static readonly IntPtr NativeFieldInfoPtr_distanceMin;

		// Token: 0x0400419E RID: 16798
		private static readonly IntPtr NativeFieldInfoPtr_distanceMax;

		// Token: 0x0400419F RID: 16799
		private static readonly IntPtr NativeFieldInfoPtr_ScrollSensativity;

		// Token: 0x040041A0 RID: 16800
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x040041A1 RID: 16801
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040041A2 RID: 16802
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040041A3 RID: 16803
		private static readonly IntPtr NativeFieldInfoPtr_targetx;

		// Token: 0x040041A4 RID: 16804
		private static readonly IntPtr NativeFieldInfoPtr_targety;

		// Token: 0x040041A5 RID: 16805
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040041A6 RID: 16806
		private static readonly IntPtr NativeFieldInfoPtr_hoveringUI;

		// Token: 0x040041A7 RID: 16807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040041A8 RID: 16808
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040041A9 RID: 16809
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040041AA RID: 16810
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x040041AB RID: 16811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
