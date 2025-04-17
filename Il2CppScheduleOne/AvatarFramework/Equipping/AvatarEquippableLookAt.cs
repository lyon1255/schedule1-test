using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Equipping
{
	// Token: 0x020005FE RID: 1534
	public class AvatarEquippableLookAt : MonoBehaviour
	{
		// Token: 0x0600872F RID: 34607 RVA: 0x0023B2F8 File Offset: 0x002394F8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEquippableLookAt()
		{
			Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Equipping", "AvatarEquippableLookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr);
			AvatarEquippableLookAt.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "Priority");
			AvatarEquippableLookAt.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, "avatar");
			AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680171);
			AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680172);
			AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr, 100680173);
		}

		// Token: 0x06008730 RID: 34608 RVA: 0x0023B38C File Offset: 0x0023958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251266, XrefRangeEnd = 251280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008731 RID: 34609 RVA: 0x0023B3C0 File Offset: 0x002395C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 251280, XrefRangeEnd = 251287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008732 RID: 34610 RVA: 0x0023B3F4 File Offset: 0x002395F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippableLookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEquippableLookAt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEquippableLookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008733 RID: 34611 RVA: 0x00040529 File Offset: 0x0003E729
		public AvatarEquippableLookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x06008734 RID: 34612 RVA: 0x0023B430 File Offset: 0x00239630
		// (set) Token: 0x06008735 RID: 34613 RVA: 0x00040532 File Offset: 0x0003E732
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x06008736 RID: 34614 RVA: 0x0023B458 File Offset: 0x00239658
		// (set) Token: 0x06008737 RID: 34615 RVA: 0x0004054D File Offset: 0x0003E74D
		public unsafe Avatar avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEquippableLookAt.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BFA RID: 23546
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005BFB RID: 23547
		private static readonly IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005BFC RID: 23548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005BFD RID: 23549
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005BFE RID: 23550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
