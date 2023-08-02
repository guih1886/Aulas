package com.myorg;

import software.amazon.awscdk.Stack;
import software.amazon.awscdk.StackProps;
import software.amazon.awscdk.services.ec2.Vpc;
import software.constructs.Construct;

public class AluraVPCStack extends Stack {
    private Vpc vpc;
    public AluraVPCStack(final Construct scope, final String id) {
        this(scope, id, null);
    }

    public AluraVPCStack(final Construct scope, final String id, final StackProps props) {
        super(scope, id, props);

        vpc = Vpc.Builder.create(this, "AluraVpc").maxAzs(3).build();
    }

    public Vpc getVpc() {
        return vpc;
    }
}
