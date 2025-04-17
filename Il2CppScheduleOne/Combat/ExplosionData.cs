using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000491 RID: 1169
	[StructLayout(2)]
	public struct ExplosionData
	{
		// Token: 0x0600652A RID: 25898 RVA: 0x001C8DBC File Offset: 0x001C6FBC
		// Note: this type is marked as 'beforefieldinit'.
		static ExplosionData()
		{
			Il2CppClassPointerStore<ExplosionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "ExplosionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr);
			ExplosionData.NativeFieldInfoPtr_DamageRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DamageRadius");
			ExplosionData.NativeFieldInfoPtr_MaxDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxDamage");
			ExplosionData.NativeFieldInfoPtr_PushForceRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "PushForceRadius");
			ExplosionData.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "MaxPushForce");
			ExplosionData.NativeFieldInfoPtr_DefaultSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, "DefaultSmall");
			ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, 100676104);
		}

		// Token: 0x0600652B RID: 25899 RVA: 0x001C8E64 File Offset: 0x001C7064
		[CallerCount(0)]
		public unsafe ExplosionData(float damageRadius, float maxDamage, float maxPushForce)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref damageRadius;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDamage;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPushForce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExplosionData.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600652C RID: 25900 RVA: 0x0002FD6D File Offset: 0x0002DF6D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExplosionData>.NativeClassPtr, ref this));
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x001C8EB4 File Offset: 0x001C70B4
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x0002FD7F File Offset: 0x0002DF7F
		public unsafe static ExplosionData DefaultSmall
		{
			get
			{
				ExplosionData result;
				IL2CPP.il2cpp_field_static_get_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExplosionData.NativeFieldInfoPtr_DefaultSmall, (void*)(&value));
			}
		}

		// Token: 0x04004503 RID: 17667
		private static readonly IntPtr NativeFieldInfoPtr_DamageRadius;

		// Token: 0x04004504 RID: 17668
		private static readonly IntPtr NativeFieldInfoPtr_MaxDamage;

		// Token: 0x04004505 RID: 17669
		private static readonly IntPtr NativeFieldInfoPtr_PushForceRadius;

		// Token: 0x04004506 RID: 17670
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04004507 RID: 17671
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSmall;

		// Token: 0x04004508 RID: 17672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;

		// Token: 0x04004509 RID: 17673
		[FieldOffset(0)]
		public float DamageRadius;

		// Token: 0x0400450A RID: 17674
		[FieldOffset(4)]
		public float MaxDamage;

		// Token: 0x0400450B RID: 17675
		[FieldOffset(8)]
		public float PushForceRadius;

		// Token: 0x0400450C RID: 17676
		[FieldOffset(12)]
		public float MaxPushForce;
	}
}
