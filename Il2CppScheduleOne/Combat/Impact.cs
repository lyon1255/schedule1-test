using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000494 RID: 1172
	[Serializable]
	public class Impact : Il2CppSystem.Object
	{
		// Token: 0x06006533 RID: 25907 RVA: 0x001C8FC0 File Offset: 0x001C71C0
		// Note: this type is marked as 'beforefieldinit'.
		static Impact()
		{
			Il2CppClassPointerStore<Impact>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "Impact");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Impact>.NativeClassPtr);
			Impact.NativeFieldInfoPtr_Hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "Hit");
			Impact.NativeFieldInfoPtr_HitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "HitPoint");
			Impact.NativeFieldInfoPtr_ImpactForceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForceDirection");
			Impact.NativeFieldInfoPtr_ImpactForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactForce");
			Impact.NativeFieldInfoPtr_ImpactDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactDamage");
			Impact.NativeFieldInfoPtr_ImpactType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactType");
			Impact.NativeFieldInfoPtr_ImpactSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactSource");
			Impact.NativeFieldInfoPtr_ImpactID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Impact>.NativeClassPtr, "ImpactID");
			Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676108);
			Impact.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676109);
			Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676110);
			Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Impact>.NativeClassPtr, 100676111);
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x001C90E0 File Offset: 0x001C72E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205615, RefRangeEnd = 205617, XrefRangeStart = 205609, XrefRangeEnd = 205615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact(RaycastHit hit, Vector3 hitPoint, Vector3 impactForceDirection, float impactForce, float impactDamage, EImpactType impactType, Player impactSource, int impactID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hitPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForceDirection;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactForce;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactDamage;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactType;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(impactSource);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref impactID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x001C9190 File Offset: 0x001C7390
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Impact() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Impact>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006536 RID: 25910 RVA: 0x001C91CC File Offset: 0x001C73CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205617, RefRangeEnd = 205618, XrefRangeStart = 205617, XrefRangeEnd = 205617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLethal(EImpactType impactType)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref impactType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006537 RID: 25911 RVA: 0x001C920C File Offset: 0x001C740C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205630, RefRangeEnd = 205631, XrefRangeStart = 205618, XrefRangeEnd = 205630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerImpact(out Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Impact.NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			player = ((intPtr4 == 0) ? null : new Player(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x0002FD96 File Offset: 0x0002DF96
		public Impact(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x001C926C File Offset: 0x001C746C
		// (set) Token: 0x0600653A RID: 25914 RVA: 0x0002FD9F File Offset: 0x0002DF9F
		public unsafe RaycastHit Hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_Hit)) = value;
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600653B RID: 25915 RVA: 0x001C9294 File Offset: 0x001C7494
		// (set) Token: 0x0600653C RID: 25916 RVA: 0x0002FDBA File Offset: 0x0002DFBA
		public unsafe Vector3 HitPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_HitPoint)) = value;
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x001C92BC File Offset: 0x001C74BC
		// (set) Token: 0x0600653E RID: 25918 RVA: 0x0002FDD5 File Offset: 0x0002DFD5
		public unsafe Vector3 ImpactForceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForceDirection)) = value;
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x001C92E4 File Offset: 0x001C74E4
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
		public unsafe float ImpactForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactForce)) = value;
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x001C930C File Offset: 0x001C750C
		// (set) Token: 0x06006542 RID: 25922 RVA: 0x0002FE0B File Offset: 0x0002E00B
		public unsafe float ImpactDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactDamage)) = value;
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x001C9334 File Offset: 0x001C7534
		// (set) Token: 0x06006544 RID: 25924 RVA: 0x0002FE26 File Offset: 0x0002E026
		public unsafe EImpactType ImpactType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactType)) = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x001C935C File Offset: 0x001C755C
		// (set) Token: 0x06006546 RID: 25926 RVA: 0x0002FE41 File Offset: 0x0002E041
		public unsafe NetworkObject ImpactSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x001C938C File Offset: 0x001C758C
		// (set) Token: 0x06006548 RID: 25928 RVA: 0x0002FE60 File Offset: 0x0002E060
		public unsafe int ImpactID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Impact.NativeFieldInfoPtr_ImpactID)) = value;
			}
		}

		// Token: 0x04004516 RID: 17686
		private static readonly IntPtr NativeFieldInfoPtr_Hit;

		// Token: 0x04004517 RID: 17687
		private static readonly IntPtr NativeFieldInfoPtr_HitPoint;

		// Token: 0x04004518 RID: 17688
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForceDirection;

		// Token: 0x04004519 RID: 17689
		private static readonly IntPtr NativeFieldInfoPtr_ImpactForce;

		// Token: 0x0400451A RID: 17690
		private static readonly IntPtr NativeFieldInfoPtr_ImpactDamage;

		// Token: 0x0400451B RID: 17691
		private static readonly IntPtr NativeFieldInfoPtr_ImpactType;

		// Token: 0x0400451C RID: 17692
		private static readonly IntPtr NativeFieldInfoPtr_ImpactSource;

		// Token: 0x0400451D RID: 17693
		private static readonly IntPtr NativeFieldInfoPtr_ImpactID;

		// Token: 0x0400451E RID: 17694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RaycastHit_Vector3_Vector3_Single_Single_EImpactType_Player_Int32_0;

		// Token: 0x0400451F RID: 17695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004520 RID: 17696
		private static readonly IntPtr NativeMethodInfoPtr_IsLethal_Public_Static_Boolean_EImpactType_0;

		// Token: 0x04004521 RID: 17697
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerImpact_Public_Boolean_byref_Player_0;
	}
}
