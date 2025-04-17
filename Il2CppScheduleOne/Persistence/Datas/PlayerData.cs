using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A8 RID: 680
	[Serializable]
	public class PlayerData : SaveData
	{
		// Token: 0x0600312C RID: 12588 RVA: 0x0010C984 File Offset: 0x0010AB84
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerData()
		{
			Il2CppClassPointerStore<PlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerData>.NativeClassPtr);
			PlayerData.NativeFieldInfoPtr_PlayerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "PlayerCode");
			PlayerData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Position");
			PlayerData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "Rotation");
			PlayerData.NativeFieldInfoPtr_IntroCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, "IntroCompleted");
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100668829);
			PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerData>.NativeClassPtr, 100668830);
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x0010CA2C File Offset: 0x0010AC2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130988, RefRangeEnd = 130991, XrefRangeStart = 130984, XrefRangeEnd = 130988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData(string playerCode, Vector3 playerPos, float playerRot, bool introCompleted) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerRot;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref introCompleted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x0010CAA4 File Offset: 0x0010ACA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130994, RefRangeEnd = 130995, XrefRangeStart = 130991, XrefRangeEnd = 130994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x0001A3EE File Offset: 0x000185EE
		public PlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0010CAE0 File Offset: 0x0010ACE0
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0001A3F7 File Offset: 0x000185F7
		public unsafe string PlayerCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_PlayerCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0010CB08 File Offset: 0x0010AD08
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x0001A416 File Offset: 0x00018616
		public unsafe Vector3 Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x0010CB30 File Offset: 0x0010AD30
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x0001A431 File Offset: 0x00018631
		public unsafe float Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0010CB58 File Offset: 0x0010AD58
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0001A44C File Offset: 0x0001864C
		public unsafe bool IntroCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerData.NativeFieldInfoPtr_IntroCompleted)) = value;
			}
		}

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeFieldInfoPtr_PlayerCode;

		// Token: 0x04002007 RID: 8199
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x04002008 RID: 8200
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002009 RID: 8201
		private static readonly IntPtr NativeFieldInfoPtr_IntroCompleted;

		// Token: 0x0400200A RID: 8202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Vector3_Single_Boolean_0;

		// Token: 0x0400200B RID: 8203
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
