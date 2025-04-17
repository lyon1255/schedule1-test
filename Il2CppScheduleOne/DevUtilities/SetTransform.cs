using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000468 RID: 1128
	public class SetTransform : MonoBehaviour
	{
		// Token: 0x060061C0 RID: 25024 RVA: 0x001BD6F4 File Offset: 0x001BB8F4
		// Note: this type is marked as 'beforefieldinit'.
		static SetTransform()
		{
			Il2CppClassPointerStore<SetTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "SetTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetTransform>.NativeClassPtr);
			SetTransform.NativeFieldInfoPtr_SetOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnAwake");
			SetTransform.NativeFieldInfoPtr_SetOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnUpdate");
			SetTransform.NativeFieldInfoPtr_SetOnLateUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetOnLateUpdate");
			SetTransform.NativeFieldInfoPtr_SetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetPosition");
			SetTransform.NativeFieldInfoPtr_LocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalPosition");
			SetTransform.NativeFieldInfoPtr_SetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetRotation");
			SetTransform.NativeFieldInfoPtr_LocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalRotation");
			SetTransform.NativeFieldInfoPtr_SetScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "SetScale");
			SetTransform.NativeFieldInfoPtr_LocalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, "LocalScale");
			SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675714);
			SetTransform.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675715);
			SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675716);
			SetTransform.NativeMethodInfoPtr_Set_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675717);
			SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetTransform>.NativeClassPtr, 100675718);
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x001BD83C File Offset: 0x001BBA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201205, XrefRangeEnd = 201206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x001BD870 File Offset: 0x001BBA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201206, XrefRangeEnd = 201207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x001BD8A4 File Offset: 0x001BBAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201207, XrefRangeEnd = 201208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x001BD8D8 File Offset: 0x001BBAD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 201223, RefRangeEnd = 201226, XrefRangeStart = 201208, XrefRangeEnd = 201223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr_Set_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x001BD90C File Offset: 0x001BBB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201226, XrefRangeEnd = 201233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x0002E309 File Offset: 0x0002C509
		public SetTransform(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x060061C7 RID: 25031 RVA: 0x001BD948 File Offset: 0x001BBB48
		// (set) Token: 0x060061C8 RID: 25032 RVA: 0x0002E312 File Offset: 0x0002C512
		public unsafe bool SetOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnAwake)) = value;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060061C9 RID: 25033 RVA: 0x001BD970 File Offset: 0x001BBB70
		// (set) Token: 0x060061CA RID: 25034 RVA: 0x0002E32D File Offset: 0x0002C52D
		public unsafe bool SetOnUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnUpdate)) = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060061CB RID: 25035 RVA: 0x001BD998 File Offset: 0x001BBB98
		// (set) Token: 0x060061CC RID: 25036 RVA: 0x0002E348 File Offset: 0x0002C548
		public unsafe bool SetOnLateUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetOnLateUpdate)) = value;
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060061CD RID: 25037 RVA: 0x001BD9C0 File Offset: 0x001BBBC0
		// (set) Token: 0x060061CE RID: 25038 RVA: 0x0002E363 File Offset: 0x0002C563
		public unsafe bool SetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetPosition)) = value;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060061CF RID: 25039 RVA: 0x001BD9E8 File Offset: 0x001BBBE8
		// (set) Token: 0x060061D0 RID: 25040 RVA: 0x0002E37E File Offset: 0x0002C57E
		public unsafe Vector3 LocalPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalPosition)) = value;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060061D1 RID: 25041 RVA: 0x001BDA10 File Offset: 0x001BBC10
		// (set) Token: 0x060061D2 RID: 25042 RVA: 0x0002E399 File Offset: 0x0002C599
		public unsafe bool SetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetRotation)) = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060061D3 RID: 25043 RVA: 0x001BDA38 File Offset: 0x001BBC38
		// (set) Token: 0x060061D4 RID: 25044 RVA: 0x0002E3B4 File Offset: 0x0002C5B4
		public unsafe Vector3 LocalRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalRotation)) = value;
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x001BDA60 File Offset: 0x001BBC60
		// (set) Token: 0x060061D6 RID: 25046 RVA: 0x0002E3CF File Offset: 0x0002C5CF
		public unsafe bool SetScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_SetScale)) = value;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x001BDA88 File Offset: 0x001BBC88
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x0002E3EA File Offset: 0x0002C5EA
		public unsafe Vector3 LocalScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetTransform.NativeFieldInfoPtr_LocalScale)) = value;
			}
		}

		// Token: 0x040042AC RID: 17068
		private static readonly IntPtr NativeFieldInfoPtr_SetOnAwake;

		// Token: 0x040042AD RID: 17069
		private static readonly IntPtr NativeFieldInfoPtr_SetOnUpdate;

		// Token: 0x040042AE RID: 17070
		private static readonly IntPtr NativeFieldInfoPtr_SetOnLateUpdate;

		// Token: 0x040042AF RID: 17071
		private static readonly IntPtr NativeFieldInfoPtr_SetPosition;

		// Token: 0x040042B0 RID: 17072
		private static readonly IntPtr NativeFieldInfoPtr_LocalPosition;

		// Token: 0x040042B1 RID: 17073
		private static readonly IntPtr NativeFieldInfoPtr_SetRotation;

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeFieldInfoPtr_LocalRotation;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeFieldInfoPtr_SetScale;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeFieldInfoPtr_LocalScale;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeMethodInfoPtr_Set_Private_Void_0;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
