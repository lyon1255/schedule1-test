using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200060E RID: 1550
	public class AvatarSeatSet : MonoBehaviour
	{
		// Token: 0x06008931 RID: 35121 RVA: 0x00240BCC File Offset: 0x0023EDCC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarSeatSet()
		{
			Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarSeatSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr);
			AvatarSeatSet.NativeFieldInfoPtr_Seats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "Seats");
			AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680372);
			AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680373);
			AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, 100680374);
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x00240C4C File Offset: 0x0023EE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253070, XrefRangeEnd = 253077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetFirstFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00240C8C File Offset: 0x0023EE8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 253105, RefRangeEnd = 253112, XrefRangeStart = 253077, XrefRangeEnd = 253105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeat GetRandomFreeSeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr3) : null;
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00240CCC File Offset: 0x0023EECC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarSeatSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00041848 File Offset: 0x0003FA48
		public AvatarSeatSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06008936 RID: 35126 RVA: 0x00240D08 File Offset: 0x0023EF08
		// (set) Token: 0x06008937 RID: 35127 RVA: 0x00041851 File Offset: 0x0003FA51
		public unsafe Il2CppReferenceArray<AvatarSeat> Seats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AvatarSeat>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarSeatSet.NativeFieldInfoPtr_Seats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005D2C RID: 23852
		private static readonly IntPtr NativeFieldInfoPtr_Seats;

		// Token: 0x04005D2D RID: 23853
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005D2E RID: 23854
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomFreeSeat_Public_AvatarSeat_0;

		// Token: 0x04005D2F RID: 23855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("ScheduleOne.AvatarFramework.Animation.AvatarSeatSet+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D652 RID: 54866 RVA: 0x00330588 File Offset: 0x0032E788
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarSeatSet>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr);
				AvatarSeatSet.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9");
				AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, "<>9__2_0");
				AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680376);
				AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr, 100680377);
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x00330604 File Offset: 0x0032E804
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarSeatSet.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x00330640 File Offset: 0x0032E840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253066, XrefRangeEnd = 253070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomFreeSeat_b__2_0(AvatarSeat x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarSeatSet.__c.NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D655 RID: 54869 RVA: 0x00068512 File Offset: 0x00066712
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700426C RID: 17004
			// (get) Token: 0x0600D656 RID: 54870 RVA: 0x00330690 File Offset: 0x0032E890
			// (set) Token: 0x0600D657 RID: 54871 RVA: 0x0006851B File Offset: 0x0006671B
			public unsafe static AvatarSeatSet.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700426D RID: 17005
			// (get) Token: 0x0600D658 RID: 54872 RVA: 0x003306B8 File Offset: 0x0032E8B8
			// (set) Token: 0x0600D659 RID: 54873 RVA: 0x0006852D File Offset: 0x0006672D
			public unsafe static Func<AvatarSeat, bool> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AvatarSeat, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarSeatSet.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009024 RID: 36900
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009025 RID: 36901
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04009026 RID: 36902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009027 RID: 36903
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomFreeSeat_b__2_0_Internal_Boolean_AvatarSeat_0;
		}
	}
}
